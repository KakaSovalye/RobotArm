from numpy import *
from math import sin, cos, asin, acos, atan, sqrt, degrees, radians, pi
from serial import Serial
import matplotlib.pyplot as plt

k0 = 122    # Platform
k1 = 82     # Alt kol
k2 = 83     # Üst kol
k3 = 150    # Kiskac sonu

Plt=90
Alt=94
Ust=80

rTemel=90
rPlatform=180
rAltKol=86
rUstKol=100
rBurgu=100
rKiskac=0

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

        # print('Platform : ', Platform)
        # print('Alt Kol : ', AltKol)
        # print('Ust Kol : ', UstKol)

        return y, x, angle
    except:
        # print('Erişilemez Nokta')
        return -1,-1,-1

X=0
Y=0
ANG=0

# plt.xlim([-10,316])
# plt.ylim([-10,316])
# for x in range(0,316,10):
#     for y in range(0,316,10):
#         X, Y, ANG = IKCalc(y, x, 11)
#         if (X != -1):
#             plt.scatter(X, Y)
# plt.show()

plt.xlim([-10,316])
plt.ylim([-10,316])
plt.xlabel("X koordinatı")
plt.ylabel("Y koordinatı")
for ang in range(144):
    for x in range(0,316,2):
        for y in range(0,316,2):
            X,Y,ANG=IKCalc(y,x,ang)
            if (X!=-1):
                plt.scatter(X,Y)
    plt.title("Robot kolu "+str(ang)+" derece el için çalışma zarfı")
    plt.savefig("data/"+str(ang).zfill(3)+".png")
    plt.clf()
    plt.xlim([-10, 316])
    plt.ylim([-10, 316])
    plt.xlabel("X koordinatı")
    plt.ylabel("Y koordinatı")


# fcounter=1
# counter=0
#
# f= open("data/Output"+str(fcounter)+".csv","w")
# f.write("X;Y;ANGLE;\n")
# fcounter+=1
# for ang in range(180):
#     for x in range(315):
#         for y in range(315):
#             X,Y,ANG=IKCalc(y,x,ang)
#             if (X!=-1):
#                 counter += 1
#                 if (counter > 65500):
#                     f.close()
#                     f = open("data/Output" + str(fcounter) + ".csv", "w")
#                     f.write("X;Y;ANGLE;\n")
#                     fcounter += 1
#                     counter = 0
#                 f.write(str(X) + ';' + str(Y) + ';' + str(ANG)+";\n")
#
# f.close()
