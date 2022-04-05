using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotKolKontrol.Siniflar
{
    class IKKontrol
    {
        // Kol eklemleri uzunlukları
        private int eklem0 = 122, eklem1 = 82, eklem2 = 83, eklem3 = 150;

        // Değişim delta değerleri
        private int koordinatDegisim = 2, dereceDegisim = 1;

        //Veri seri olarak Arduino'ya gönderilecek mi?
        private bool boolArduino = false;

        //Robot sifir posizyonu dereceleri
        private int rTemel = 90,
                    rPlatform = 100,
                    rAltKol = 86,
                    rUstKol = 100,
                    rBurgu = 100,
                    rKiskac = 0;


        private int _platform = 100;
        private int _altKol = 86;
        private int _ustKol = 100;


        public int Platform { get => _platform; set => _platform = value; }
        public int AltKol { get => _altKol; set => _altKol = value; }
        public int UstKol { get => _ustKol; set => _ustKol = value; }

        public IKKontrol()
        {

        }

        private double Deg2Rad(int degree)
        {
            return (Math.PI * degree / 180.0);
        }

        private double Rad2Deg(double rad)
        {
            return (180 / Math.PI) * rad;
        }


        public void EklemleriPozisyonla(int x, int y, int angle)
        {
            int px = x;
            int py = y;

            double fi = Deg2Rad(angle);

            double wx = px - eklem3 * Math.Cos(fi);
            double wy = py - eklem3 * Math.Sin(fi);

            double delta = Math.Pow(wx,2) + Math.Pow(wy,2);

            double c2 = (delta - Math.Pow(eklem1, 2) - Math.Pow(eklem2, 2)) / (2 * eklem1 * eklem2);
            double s2 = Math.Sqrt(1 - Math.Pow(c2, 2));

            double teta_2 = Math.Atan2(s2, c2);

            double s1 = ((eklem1 + eklem2 * c2) * wy - eklem2 * s2 * wx) / delta;
            double c1 = ((eklem1 + eklem2 * c2) * wx + eklem2 * s2 * wy) / delta;

            double teta_1 = Math.Atan2(s1, c1);
            double teta_3 = fi - teta_1 - teta_2;
            

            if (Platform > 180 || Platform < 0 || AltKol > 180 || AltKol < 0 || UstKol > 180 || UstKol < 0)
                return;

            _platform = 90 + (int)(Rad2Deg(teta_1));
            _altKol = rAltKol + (int)(Rad2Deg(teta_2));
            _ustKol = rUstKol + (int)(Rad2Deg(teta_3));



        }


    }
}
