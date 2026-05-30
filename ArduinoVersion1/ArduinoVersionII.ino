// --- CONFIGURACIÓN DE PINES ---
const int pinBombaUnica = 2; // Bomba que genera presión
const int valvulas[] = {3, 4, 5, 6}; // Electroválvulas 1, 2, 3, 4
const int sensores[] = {7, 8, 9, 10}; // Cables de cobre para Tanque Lleno

void setup() {
  Serial.begin(9600);
  
  pinMode(pinBombaUnica, OUTPUT);
  digitalWrite(pinBombaUnica, LOW); // Asegurar que inicie apagada

  for (int i = 0; i < 4; i++) {
    pinMode(valvulas[i], OUTPUT);
    digitalWrite(valvulas[i], LOW);
    
    // IMPORTANTE: INPUT_PULLUP mantiene el pin en HIGH (1) 
    // y cae a LOW (0) cuando el agua salada toca el cable a GND
    pinMode(sensores[i], INPUT_PULLUP); 
  }
}

void loop() {
  // 1. REVISAR COMANDOS DESDE C#
  if (Serial.available() > 0) {
    char comando = Serial.read();
    procesarComando(comando);
  }

  // 2. MONITOREO DE SENSORES (SEGURIDAD / TANQUE LLENO)
  for (int i = 0; i < 4; i++) {
    // Si el sensor lee LOW, significa que el agua cerró el circuito
    if (digitalRead(sensores[i]) == LOW) {
      detencionInmediata(i);
    }
  }
}

void procesarComando(char c) {
  switch (c) {
    // ENCENDER VÁLVULAS
    case '1': digitalWrite(valvulas[0], HIGH); break;
    case '2': digitalWrite(valvulas[1], HIGH); break;
    case '3': digitalWrite(valvulas[2], HIGH); break;
    case '4': digitalWrite(valvulas[3], HIGH); break;

    // APAGAR VÁLVULAS (q, w, e, r según tu array en C#)
    case 'q': digitalWrite(valvulas[0], LOW); break;
    case 'w': digitalWrite(valvulas[1], LOW); break;
    case 'e': digitalWrite(valvulas[2], LOW); break;
    case 'r': digitalWrite(valvulas[3], LOW); break;

    // CONTROL DE BOMBA ÚNICA
    case 'b': digitalWrite(pinBombaUnica, HIGH); break;
    case 'x': digitalWrite(pinBombaUnica, LOW); break;
  }
}

void detencionInmediata(int indiceVálvula) {
  // 1. Cerramos la válvula que está tirando agua
  digitalWrite(valvulas[indiceVálvula], LOW);
  
  // 2. Apagamos la bomba única (opcional: podrías esperar un poco si hay otras abiertas)
  digitalWrite(pinBombaUnica, LOW);
  
  // 3. Avisamos a C# para que salte el MessageBox
  // Enviamos "LLENO" para que el DataReceivedHandler de C# lo reconozca
  Serial.println("LLENO");
  
  // Pequeña pausa para evitar enviar mil mensajes por segundo
  delay(1000); 
}