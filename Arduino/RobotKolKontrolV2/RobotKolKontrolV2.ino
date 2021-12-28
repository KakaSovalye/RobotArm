#include <Servo.h>

Servo Temel, Platform, AltKol, UstKol, Burgu, Kiskac;
int ServoDelay=30, TemelPos=90, PlatformPos=90, AltKolPos=86, UstKolPos=100, BurguPos=100, KiskacPos=0;
int tTemel=-1, tPlatform=-1, tAltKol=-1, tUstKol=-1, tBurgu=-1, tKiskac=-1, tReset=-1, tStatus=-1, tDipMotordanBaslama=-1;
bool boolFeedback=false, boolDinlemeyeHazir=true, flipflop=false;

unsigned long previousMillis =0;
const long interval = 100;

// Platform Min 27, Kiskac 0 açık 180 kapali

void MotorKontrol()
{
  if (tTemel!=-1 || tPlatform!=-1 || tAltKol!=-1 || tUstKol!=-1 || tBurgu!=-1 || tKiskac!=-1)
  {  // Hareket dengeleme
    if(flipflop)
    {  
      MotorCevir(Temel,tTemel);
      MotorCevir(Platform,tPlatform);
      MotorCevir(AltKol,tAltKol);
      MotorCevir(UstKol,tUstKol);
      MotorCevir(Burgu,tBurgu);
      MotorCevir(Kiskac,tKiskac);
      flipflop=false;
    }
    else
    {
      MotorCevir(Kiskac,tKiskac);
      MotorCevir(Burgu,tBurgu); 
      MotorCevir(UstKol,tUstKol);
      MotorCevir(AltKol,tAltKol);
      MotorCevir(Platform,tPlatform);
      MotorCevir(Temel,tTemel);
      flipflop=true;      
    }
    boolDinlemeyeHazir=false;
  }
  else
  {
    Serial.println("R-1S-1D-1T"+String(Temel.read())+"P"+String(Platform.read())+"A"+String(AltKol.read())+"U"+String(UstKol.read())
        +"B"+String(Burgu.read())+"K"+String(Kiskac.read()));  
    boolDinlemeyeHazir=true;
  }
}

void MotorCevir(Servo &Motor, int &Hedef)
{
  if (Hedef==-1)
    return;
  int pozisyon = Motor.read();
  if (Hedef==pozisyon)
  {
    Hedef=-1;
    return;
  }
  
  if (pozisyon>Hedef)
  {
    pozisyon--;
    Motor.write(pozisyon);
  }
  else if (pozisyon<Hedef)
  {
    pozisyon++;
    Motor.write(pozisyon);
  }
  else if (pozisyon==Hedef)
  {
    Hedef=-1;
  }
}

void MotorCevirKurulum(Servo &Motor, int Hedef, int Hiz=ServoDelay) 
{

  if (Hedef > 180 || Hedef < 0)
  return;

  boolFeedback=true;
  int pozisyon = Motor.read();
  
  while (pozisyon!=Hedef)
  {   
      pozisyon = Motor.read();
      if (pozisyon<Hedef && pozisyon<=180 && pozisyon>=0)
      {
        pozisyon++;
        Motor.write(pozisyon);
        delay(Hiz);
      }
      else if (pozisyon>Hedef && pozisyon<=180 && pozisyon>=0)
      {
        pozisyon--;
        Motor.write(pozisyon);
        delay(Hiz);
      }     
  }  
}

void ResetPozisyonunaGit()
{
  MotorCevirKurulum(Temel,90);
  MotorCevirKurulum(Platform,90);
  MotorCevirKurulum(AltKol,86);
  MotorCevirKurulum(UstKol,100);
  MotorCevirKurulum(Burgu,100);
  MotorCevirKurulum(Kiskac,0);
}

void tPosResetle()
{
  tTemel=-1, tPlatform=-1, tAltKol=-1, tUstKol=-1, tBurgu=-1, tKiskac=-1, tStatus=-1, tReset=-1, tDipMotordanBaslama=-1;
}


void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  
  Temel.write(TemelPos);
  Platform.write(PlatformPos);
  AltKol.write(AltKolPos);
  UstKol.write(UstKolPos);
  Burgu.write(BurguPos);
  Kiskac.write(KiskacPos);
  
  Temel.attach(10);
  Platform.attach(11);
  AltKol.attach(9);
  UstKol.attach(3);
  Burgu.attach(5);
  Kiskac.attach(6);

}



void loop() {
  // put your main code here, to run repeatedly:
  
  unsigned long currentMillis = millis();
  if (currentMillis - previousMillis >= interval)
  {
    previousMillis = currentMillis;
    MotorKontrol();
  }


  if (boolDinlemeyeHazir)  
  {
    if (Serial.available()>0)
    {
      if (Serial.read()=='R')
        tReset = Serial.parseInt();
        if (Serial.read()=='S')
          tStatus=Serial.parseInt();
          if (Serial.read()=='D')
            tDipMotordanBaslama=Serial.parseInt();
            if (Serial.read() == 'T')  
              tTemel = Serial.parseInt();
              if (Serial.read() == 'P')  
                tPlatform = Serial.parseInt();
                if (Serial.read() == 'A')  
                  tAltKol = Serial.parseInt();
                  if (Serial.read() == 'U')  
                    tUstKol = Serial.parseInt();
                    if (Serial.read() == 'B')  
                      tBurgu = Serial.parseInt();
                      if (Serial.read() == 'K')  
                        tKiskac = Serial.parseInt();
                          
                          
    }
  
    if (tReset!=-1)
    {
      tPosResetle();
      ResetPozisyonunaGit();          
    }
    else
    if (tStatus!=-1)
    {// Burayı uçurabiliriz??
      tPosResetle();
      Serial.println((String)"---------------------------");
      Serial.println((String)"Temel :"+Temel.read());
      Serial.println((String)"Platform :"+Platform.read());
      Serial.println((String)"Alt Kol :"+AltKol.read());
      Serial.println((String)"Ust Kol :"+UstKol.read());
      Serial.println((String)"Burgu :"+Burgu.read());
      Serial.println((String)"Kiskac :"+Kiskac.read());
      tStatus=-1;
    }
    else
    {
      if (tDipMotordanBaslama==-1)
      {
        
      }
      if (boolFeedback)
      {
        boolFeedback=false;
//        Serial.println("R-1S-1D-1T"+String(Temel.read())+"P"+String(Platform.read())+"A"+String(AltKol.read())+"U"+String(UstKol.read())
//        +"B"+String(Burgu.read())+"K"+String(Kiskac.read()));      
      }
      
    }
    


}
      
}
