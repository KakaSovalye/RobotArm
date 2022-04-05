from numpy import *
from math import sin, cos, asin, acos, atan, sqrt, degrees, radians, pi
from serial import Serial
import pyodbc
from pwinput import pwinput
from termcolor import colored

# bağlantılar ve uzunlukları mm bazında

k0 = 122    # Platform
k1 = 82     # Alt kol
k2 = 83     # Üst kol
k3 = 150    # Kiskac sonu

koordinatDegisim=2
dereceDegisim=1

arduino = False
programCik=False

try:
    ArduinoSerial=Serial('com9',9600,timeout=0.1)
    arduino=True
except:
    arduino=False

# Robot 0 pozisyonu ince ayar
rTemel=90
rPlatform=180
rAltKol=86
rUstKol=100
rBurgu=100
rKiskac=0

ServerIP="0.0.0.0"
Database = "Null"
UID ="none"
PWD ="none"
DBVerisiGirildi = False

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

def IKCalc(x,y,angle):
    try:
        # ulaşılmak istenen nokta koordinatı
        # robot kolunun x ve y'si ters işleniyor :)
        px = x
        py = y


        # k3'ün dikey ile açısı
        fi = angle
        fi = deg2rad(fi)


        # inverse kinematik
        wx = px - k3*cos(fi)
        wy = py - k3*sin(fi)


        # wx = px - k3 * sin(fi)
        # wy = py - k3 * cos(fi)

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

        if (Platform>180 or Platform <0 or AltKol>180 or AltKol<0 or UstKol>180 or UstKol<0):
            raise

        print('Platform : ', Platform)
        print('Alt Kol : ', AltKol)
        print('Ust Kol : ', UstKol)

        return Platform, AltKol, UstKol
    except:
        print('!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!')
        print('!!!!!!!!!!!!!                       !!!!!!!!!!!!')
        print('!!!!!!!!!!!!!  ! ERİŞİLMEZ NOKTA  ! !!!!!!!!!!!!')
        print('!!!!!!!!!!!!!                       !!!!!!!!!!!!')
        print('!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!')
        return -1,-1,-1

def db_baglanti_test():
    try:
        sonuc=[]
        conn = pyodbc.connect('Driver={SQL Server};'
                              'Server='+ServerIP+';'
                              'Database='+Database+';'
                              'UID='+UID+'; PWD='+PWD, timeout=1)
        cursor = conn.cursor()
        cursor.execute("SELECT '1'")
        cursor.close()
        return True
    except pyodbc.Error as ex:
        print("Veritabanına bağlanılamadı...")
        return False

def db_veri_cek(command):
    sonuc=[]
    conn = pyodbc.connect('Driver={SQL Server};'
                          'Server='+ServerIP+';'
                          'Database='+Database+';'
                          'UID='+UID+'; PWD='+PWD)

    cursor = conn.cursor()
    cursor.execute(command)

    for row in cursor:
        sonuc.append(row)
    cursor.close()
    return sonuc

# def db_veri_guncelle(command):
#     conn = pyodbc.connect('Driver={SQL Server};'
#                           'Server='+ServerIP+';'
#                           'Database='+Database+';'
#                           'UID='+UID+'; PWD='+PWD)
#
#     cursor = conn.cursor()
#     cursor.execute(command)
#     conn.commit()
#     cursor.close()





Y=315
X=0
ANG=0

# Reset pozisyonu
rY=315
rX=0
rANG=0

Plt=90
Alt=94
Ust=80

tPlt = Plt
tAlt = Alt
tUst = Ust

Plt, Alt, Ust = IKCalc(Y,X,ANG)

print ('X: '+str(X)+' Y: '+str(Y)+' ANG: '+str(ANG))
arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
print(arduinoData)

if arduino:
    ArduinoSerial.write(arduinoData.encode('utf-8'))

while(programCik!=True):
    while (DBVerisiGirildi!=True):
        print("DB Server :")
        ServerIP=input()
        print("Database :")
        Database=input()
        print("UID :")
        UID=input()
        PWD=pwinput("Password:")
        if (db_baglanti_test()==True):
            DBVerisiGirildi=True
            print("Veritabanına bağlanıldı....")
    print("Koordinatlari x,y,a olarak giriniz. r resetler, q programı kapatır :")
    girdi = input()
    if (girdi=="r" or girdi=="R"):
        arduinoData = 'R1'
        if arduino:
            ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        X = rX
        Y = rY
        ANG = rANG
        Plt, Alt, Ust = IKCalc(Y, X, ANG)
    elif (girdi=="q" or girdi=="Q"):
        arduinoData = 'R1'
        if arduino:
            ArduinoSerial.write(arduinoData.encode('utf-8'))
        print(arduinoData)
        X = rX
        Y = rY
        ANG = rANG
        Plt, Alt, Ust = IKCalc(Y, X, ANG)
        programCik=True
    else:
        try:
            koordinatlar = girdi.split(",")
            tX=X
            tY=Y
            tANG=ANG


            X=int(koordinatlar[0])
            Y=int(koordinatlar[1])
            if (koordinatlar[2]=="-1"):
                ANG=db_veri_cek("spsel_KoordinataGoreMinAci "+str(X)+","+str(Y))[0][0]
                print("Min aci "+str(ANG))
            elif (koordinatlar[2] == "-2"):
                ANG = db_veri_cek("spsel_KoordinataGoreMaxAci " + str(X) + "," + str(Y))[0][0]
                print("Max aci " + str(ANG))
            else:
                ANG=int(koordinatlar[2])
                print("Girilen aci " + str(ANG))

            # print('X: ' + str(X) + ' Y: ' + str(Y) + ' ANG: ' + str(ANG))

            tPlt, tAlt, tUst = Plt, Alt, Ust
            Plt, Alt, Ust = IKCalc(Y, X, ANG)
            if (Plt == -1 and Alt == -1 and Ust == -1):
                X=tX
                Y=tY
                ANG=tANG
            print('X: ' + str(X) + ' Y: ' + str(Y) + ' ANG: ' + str(ANG))
            arduinoData = 'R-1S-1D-1T-1P{0:d}A{1:d}U{2:d}'.format(Plt, Alt, Ust)
            if arduino:
                ArduinoSerial.write(arduinoData.encode('utf-8'))
                fb = ArduinoSerial.readline()
                print(fb.decode('utf-8'))
            print(arduinoData)
        except:
            print("Girilen koordinatlar doğru değil")


