using System;
using System.Security.Cryptography.X509Certificates;

namespace _090323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            fiyat fiyat = new fiyat();
            fiyat.f = 1000;

            indirim indirim = new indirim();
            indirim.i = 0.5;

            urun urun = new urun();
            Console.WriteLine("Urun Adedi Gir");
            urun.u= int.Parse(Console.ReadLine());


            hesap(fiyat, indirim, urun);


            static void hesap(fiyat z,indirim x,urun v)
            {
                if (v.u>=2) 
                {
                    Console.WriteLine("Normal Fiyat:"+" "+(v.u*z.f));
                    Console.WriteLine("%50 indirim uygulanmıştır.");
                    Console.WriteLine("İndirimli Fiyat:"+" "+(z.f*x.i*v.u));
                }
                
                else
                {
                    Console.WriteLine("Indirimsiz fiyat"+" "+z.f);
                }

            }
           
        }
    }
}
