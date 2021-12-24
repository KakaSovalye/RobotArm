from numpy import *

# bağlantılar ve uzunlukları mm bazında

k0 = 125    # Platform
k1 = 82     # Alt kol
k2 = 82     # Üst kol
k3 = 70    # Kiskac
k4 = 84

# ulaşılmak istenen nokta koordinatı
px = 200
py = 0


# uç kolun (burguyu tutan kolun) x ile yapacağı açı
fi = 0
fi = deg2rad(fi)

# inverse kinematik
wx = px - k3*cos(fi)
wy = py - k3*sin(fi)

delta = wx**2 + wy**2
c2 = ( delta -k1**2 -k2**2)/(2*k1*k2)
s2 = sqrt(1-c2**2)


teta_2 = arctan2(s2, c2)
# alt kol motorunun yönü ters olduğundan -1 ile çarpılıyor.
#teta_2= -1*teta_2


s1 = ((k1+k2*c2)*wy - k2*s2*wx)/delta
c1 = ((k1+k2*c2)*wx + k2*s2*wy)/delta
teta_1 = arctan2(s1,c1)
teta_3 = fi-teta_1-teta_2

print('Platform: ', rad2deg(teta_1))
print('Alt Kol: ', rad2deg(teta_2))
print('Ust Kol: ', rad2deg(teta_3))

if (isnan(teta_1) is False and isnan(teta_2) is False and isnan(teta_3) is False):
    Platform = int(rad2deg(teta_1))
    AltKol = int(rad2deg(teta_2))
    UstKol = int(rad2deg(teta_3))

    if ( Platform < 180 or Platform >0 or
        AltKol < 180 or AltKol >0 or
        UstKol < 180 or UstKol >0 ):
            print('Platform: ', rad2deg(teta_1))
            print('Alt Kol: ', rad2deg(teta_2))
            print('Ust Kol: ', rad2deg(teta_3))

#print('R-1S-1T-1P',int(rad2deg(teta_3)), 'A',int(rad2deg(teta_2)),'U',int(rad2deg(teta_3)))