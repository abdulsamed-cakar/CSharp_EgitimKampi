using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_Metots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer----> Listele,sil,ekle,güncelle

            //void CustomerLİst()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerLİst();
            //CustomerLİst();
            //CustomerLİst();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(x + y);
            //}
            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}
            //CustomerCard("Ahmet", "Yılmaz");
            //CustomerCard("Ayşe", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(6, 8, 9);






            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name +" " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion
            Console.Read();
        }
    }
}
