// Pin de la bomba única
const int pinBomba = 2; 
// Pines de las 4 electroválvulas
int valvulas[] = {3, 4, 5, 6}; 

// NUEVO: Pin del sensor de nivel (Tanque Lleno)
const int pinSensorLleno = 7; 
bool transmitidoLleno = false; // Evita saturar el puerto serie con mensajes repetidos

void setup() {
  Serial.begin(9600);
  
  // Configuración de salidas
  pinMode(pinBomba, OUTPUT);
  digitalWrite(pinBomba, LOW);
  
  for(int i = 0; i < 4; i++) {
    pinMode(valvulas[i], OUTPUT);
    digitalWrite(valvulas[i], LOW);
  }
  
  // NUEVO: Configuración del sensor con resistencia Pull-Up interna
  // Cambiar a INPUT si usas una resistencia física externa a GND
  pinMode(pinSensorLleno, INPUT_PULLUP); 
}

void loop() {
  // 1. MONITOREO DEL SENSOR (Para el modo "Tanque Lleno" de tu C#)
  // Si usas INPUT_PULLUP, el pin pasa a LOW cuando el agua toca el sensor.
  if (digitalRead(pinSensorLleno) == LOW) { 
    if (!transmitidoLleno) {
      // Apagado de emergencia inmediato en el hardware por seguridad
      digitalWrite(pinBomba, LOW);
      for(int i = 0; i < 4; i++) {
        digitalWrite(valvulas[i], LOW);
      }
      
      // Enviar alerta a C# para activar el MessageBox y actualizar la interfaz
      Serial.println("LLENO"); 
      transmitidoLleno = true; 
    }
  } else {
    transmitidoLleno = false; // Resetear la bandera si el nivel baja
  }

  // 2. PROCESAMIENTO DE COMANDOS DESDE LA PC
  if (Serial.available() > 0) {
    char cmd = Serial.read();
    
    switch(cmd) {
      // Control de la Bomba Principal
      case 'b': digitalWrite(pinBomba, HIGH); break;
      case 'x': digitalWrite(pinBomba, LOW); break;
      
      // Electroválvula 1 (Estación 1)
      case '1': digitalWrite(valvulas[0], HIGH); break;
      case 'q': digitalWrite(valvulas[0], LOW); break;
      
      // Electroválvula 2 (Estación 2)
      case '2': digitalWrite(valvulas[1], HIGH); break;
      case 'w': digitalWrite(valvulas[1], LOW); break;
      
      // Electroválvula 3 (Estación 3)
      case '3': digitalWrite(valvulas[2], HIGH); break;
      case 'e': digitalWrite(valvulas[2], LOW); break;
      
      // Electroválvula 4 (Estación 4)
      case '4': digitalWrite(valvulas[3], HIGH); break;
      case 'r': digitalWrite(valvulas[3], LOW); break;
    }
  }
}