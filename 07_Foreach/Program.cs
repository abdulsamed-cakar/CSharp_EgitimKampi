using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1,2,3,4)

            //1-Degisken türü
            //2-Degisken adı
            //3-In
            //4-Liste,Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeste", "ankara", "istanbul", "erzurum" };

            //foreach (string x in cities)
            //{

            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 213, 34, 544, 3211, 123, 34, 56, 87, 34 };

            //foreach (int number in numbers)
            //{ 
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 213, 34, 544, 3211, 123, 34, 56, 87, 34 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 213, 34, 544, 3211, 123, 34, 56, 87, 34 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers) {
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("*********** C# Eğitim Kampı Sınav Uygulaması *******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki çğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var ?");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            //Çğrenci isimlerini ve not ort. saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------");

                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları toplama
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }


            //Öğrencilerin ortalaması
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");


                //Öğrencilerin geçip kalma durumu

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı çğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı çğrenci dersten kaldı.");
                }
                Console.WriteLine("--------------------"); ;
            }
                    #endregion

                    Console.ReadLine();
            }
        }
    }
