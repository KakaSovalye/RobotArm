#include <Servo.h>
Servo Test;

void setup() {
  // put your setup code here, to run once:
  Test.attach(3);

  Test.write(90);

}

void loop() {
  // put your main code here, to run repeatedly:
//  Test.write(180);
//  delay(1000);
//  Test.write(0);
//  delay(1000);

}
