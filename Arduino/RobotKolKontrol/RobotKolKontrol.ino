#include <Servo.h>

Servo Temel, Platform, AltKol, UstKol, Burgu, Kiskac;
int ServoDelay=30, TemelPos=90, PlatformPos=100, AltKolPos=90, UstKolPos=90, BurguPos=90, KiskacPos=0;
int tTemel=-1, tPlatform=-1, tAltKol=-1, tBurgu=-1, tKiskac=-1;

// Platform Min 27, Kiskac 0 açık 180 kapali

void MotorCevir(Servo &Motor, int Hedef) {

  if (Hedef > 180 || Hedef < 0)
  return;

  int pozisyon = Motor.read();
  
  while (pozisyon!=Hedef)
  {   
      pozisyon = Motor.read();
      if (pozisyon<Hedef && pozisyon<=180 && pozisyon>=0)
      {
        pozisyon++;
        Motor.write(pozisyon);
        delay(ServoDelay);
      }
      else if (pozisyon>Hedef && pozisyon<=180 && pozisyon>=0)
      {
        pozisyon--;
        Motor.write(pozisyon);
        delay(ServoDelay);
      }     
  }  
}


void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  
  Temel.write(TemelPos);
  Platform.write(PlatformPos);
  AltKol.write(AltKolPos);
//  UstKol.write(UstKolPos);
  Burgu.write(BurguPos);
  Kiskac.write(KiskacPos);
  
  Temel.attach(10);
  Platform.attach(11);
  AltKol.attach(9);
  UstKol.attach(3);
  Burgu.attach(5);
  Kiskac.attach(6);
  
  
//  MotorCevir(Platform, 50);
//  MotorCevir(AltKol, 90);
//  MotorCevir(Burgu, 90);
//  MotorCevir(Kiskac, 90);
//  MotorCevir(Platform, 90);
  

//  Temel.write(90);
//  Platform.write(180);
//  AltKol.write(180);
//  UstKol.write(90);
//  Burgu.write(90);
//  Kiskac.write(90);

}



void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()>0)
  {
    if (Serial.read() == 'T')  
      tTemel = Serial.parseInt();
        if (Serial.read() == 'P')  
          tPlatform = Serial.parseInt();
            if (Serial.read() == 'A')  
            tAltKol = Serial.parseInt();
              if (Serial.read() == 'B')  
              tBurgu = Serial.parseInt();
                if (Serial.read() == 'K')  
                tKiskac = Serial.parseInt();
  }

  if (tTemel!=-1)
    MotorCevir(Temel, tTemel);
  if (tPlatform !=-1)
    MotorCevir(Platform, tPlatform);
  if (tAltKol!=-1)
    MotorCevir(AltKol,tAltKol);
  if (tBurgu!=-1)
    MotorCevir(Burgu,tBurgu);
  if (tKiskac!=-1)
    MotorCevir(Kiskac,tKiskac);



      
}
