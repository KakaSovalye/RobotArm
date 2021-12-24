from numpy import *
from math import sin, cos, asin, acos, atan, sqrt, degrees, radians, pi
import cv2
import os
from serial import Serial

# bağlantılar ve uzunlukları mm bazında

k0 = 125    # Platform
k1 = 82     # Alt kol
k2 = 82     # Üst kol
k3 = 154    # Kiskac sonu

ArduinoSerial=Serial('com9',9600,timeout=0.1)

# Robot 0 pozisyonu ince ayar
rTemel=90
rPlatform=180
rAltKol=86
rUstKol=100
rBurgu=100
rKiskac=0



def coordinate_to_degrees(x, y):  # function to convert coordinates to angles from the x-axis (0~360)
    x += 0.00001  # this is to avoid zero division error in case x == 0

    if x >= 0 and y >= 0:  # first quadrant
        angle = degrees(atan(y / x))
    elif x < 0 and y >= 0:  # second quadrant
        angle = 180 + degrees(atan(y / x))
    elif x < 0 and y < 0:  # third quadrant
        angle = 180 + degrees(atan(y / x))
    elif x >= 0 and y < 0:  # forth quadrant
        angle = 360 + degrees(atan(y / x))
    return round(angle, 1)


# aci = coordinate_to_degrees(154,154)
# print(aci)

def IKCalc(x,y,angle):
    try:
        # ulaşılmak istenen nokta koordinatı
        px = x
        py = y


        # k3'ün dikey ile açısı
        fi = angle
        fi = deg2rad(fi)

        # inverse kinematik
        wx = px - k3*cos(fi)
        wy = py - k3*sin(fi)

        delta = wx**2 + wy**2
        c2 = ( delta -k1**2 -k2**2)/(2*k1*k2)
        s2 = sqrt(1-c2**2)


        teta_2 = arctan2(s2, c2)



        s1 = ((k1+k2*c2)*wy - k2*s2*wx)/delta
        c1 = ((k1+k2*c2)*wx + k2*s2*wy)/delta
        teta_1 = arctan2(s1,c1)
        teta_3 = fi-teta_1-teta_2

        Platform = 90+int(rad2deg(teta_1))
        AltKol = rAltKol + int(rad2deg(teta_2))
        UstKol = rUstKol + int(rad2deg(teta_3))

        if (AltKol>180):
            AltKol=AltKol-180
        if (UstKol>180):
            UstKol=UstKol-180


        Platform = (180-Platform)%180
        AltKol = (180-AltKol)%180
        UstKol = (180-UstKol)%180

        print('Platform : ', Platform)
        print('Alt Kol : ', AltKol)
        print('Ust Kol : ', UstKol)


        # print('Platform (İşlenmemiş): ', rad2deg(teta_1))
        # print('Alt Kol (İşlenmemiş): ', rad2deg(teta_2))
        # print('Ust Kol (İşlenmemiş): ', rad2deg(teta_3))

        return Platform, AltKol, UstKol
    except:
        print('Erişilemez Nokta')
        return -1,-1,-1






    # if (isnan(teta_1) is False and isnan(teta_2) is False and isnan(teta_3) is False):
    #     Platform = int(rad2deg(teta_1))
    #     AltKol = int(rad2deg(teta_2))
    #     UstKol = int(rad2deg(teta_3))
    #
    #     if ( Platform < 180 or Platform >0 or
    #         AltKol < 180 or AltKol >0 or
    #         UstKol < 180 or UstKol >0 ):
    #             print('Platform: ', rad2deg(teta_1))
    #             print('Alt Kol: ', rad2deg(teta_2))
    #             print('Ust Kol: ', rad2deg(teta_3))

X=318
Y=0
ANG=0

Plt=90
Alt=94
Ust=80

tPlt = Plt
tAlt = Alt
tUst = Ust

IKCalc(X,Y,ANG)

arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
print(arduinoData)

ArduinoSerial.write(arduinoData.encode('utf-8'))

while True:
    img = cv2.imread('img/robot_arm.jpg')
    img2 = cv2.resize(img,[400,400],4)
    cv2.imshow('ss',img2)
    
    if (cv2.waitKeyEx(0)==2555904):
        X+=1
        print ('X: '+str(X)+' Y: '+str(Y)+' ANG: '+str(ANG))
        tPlt,tAlt,tUst=Plt,Alt,Ust
        Plt,Alt,Ust= IKCalc(X,Y,ANG)
        arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
        ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        fb=ArduinoSerial.readline()
        print(fb)
        # print('Sağ')
    if (cv2.waitKeyEx(0)==2424832):
        X-=1
        print('X: ' + str(X) + ' Y: ' + str(Y) + ' ANG: ' + str(ANG))
        tPlt, tAlt, tUst = Plt, Alt, Ust
        Plt, Alt, Ust = IKCalc(X, Y, ANG)
        arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
        ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        fb = ArduinoSerial.readline()
        print(fb)
        # print('Sol')
    if (cv2.waitKeyEx(0)==2490368):
        Y+=1
        print('X: ' + str(X) + ' Y: ' + str(Y) + ' ANG: ' + str(ANG))
        tPlt, tAlt, tUst = Plt, Alt, Ust
        Plt, Alt, Ust = IKCalc(X, Y, ANG)
        arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
        ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        fb = ArduinoSerial.readline()
        print(fb)
        # print('Yukarı')
    if (cv2.waitKeyEx(0)==2621440):
        Y-=1
        print('X: ' + str(X) + ' Y: ' + str(Y) + ' ANG: ' + str(ANG))
        tPlt, tAlt, tUst = Plt, Alt, Ust
        Plt, Alt, Ust = IKCalc(X, Y, ANG)
        arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
        ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        fb = ArduinoSerial.readline()
        print(fb)
        # print('Aşağı')
    if (cv2.waitKeyEx(0)==122):
        ANG+=1
        print('X: ' + str(X) + ' Y: ' + str(Y) + ' ANG: ' + str(ANG))
        tPlt, tAlt, tUst = Plt, Alt, Ust
        Plt, Alt, Ust = IKCalc(X, Y, ANG)
        arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
        ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        fb = ArduinoSerial.readline()
        print(fb)
        # print('Z')
    if (cv2.waitKeyEx(0)==120):
        ANG-=1
        print('X: ' + str(X) + ' Y: ' + str(Y) + ' ANG: ' + str(ANG))
        tPlt, tAlt, tUst = Plt, Alt, Ust
        Plt, Alt, Ust = IKCalc(X, Y, ANG)
        arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
        ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        fb = ArduinoSerial.readline()
        print(fb)
        # print('X')
    if (cv2.waitKeyEx(0) == 114):
        arduinoData = 'R1'
        ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        X = 318
        Y = 0
        ANG = 0





    # keyCode = cv2.waitKeyEx(0)
    #
    # print(str(keyCode))

#print('R-1S-1T-1P',int(rad2deg(teta_3)), 'A',int(rad2deg(teta_2)),'U',int(rad2deg(teta_3)))