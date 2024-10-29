using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnek

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Turuncu";
            //colors[3] = "Yeşil";

            //Console.WriteLine(colors[3]);

            //int[] numbers = new int[10];
            //numbers[0] = 78;
            //numbers[4] = 23;
            //numbers[5] = 32;
            //numbers[7] = 14;
            //numbers[9] = 51;
            //numbers[8] = 86;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "İstanbul", "Bursa", "Eskişehir", "Erzurum" };

            //Console.WriteLine(cities[0]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleyelim

            //string[] colors = { "Sarı", "Beyaz", "Siyah", "Kırmızı", "Yeşil" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //char[] symbols = { 'A', 'B', 'C', 'D', '/', '_' };

            //Console.WriteLine(symbols[4]);

            //int[] myArray = { 37, 46, 78, 56, 112, 43, 56, 65 };

            //int maxNumber = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //int[] myArray = { 37, 46, 78, 56, 112, 43, 56, 65 };

            //Array.Sort(myArray);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //int[] myArray = { 37, 46, 78, 56, 112, 43, 56, 65 };
            //Array.Reverse(myArray);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}


            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ahmet", "mehmet", "ayse", "kerem" };

            //int index = Array.IndexOf(customers, "kerem");

            //Console.WriteLine(index);

            //int[] dizi = { 24, 45, 464, 123, 4, 213, 34, 223 };

            //Console.WriteLine("Dizinin En büyük elemanı: "+ dizi.Max() + " Dizinin en kücük elemanı: "+ dizi.Min());



            #endregion

            #region Kullanıcıdan Deger Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri giriniz: ");
            //    cities[i]=Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            #endregion
            Console.Read();
        }
    }
}
