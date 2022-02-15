// See https://aka.ms/new-console-template for more information
using System;

namespace console_degiskenler 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger; 
            deger = 2;
            string degisken = null;
            string Degisken = null;


            Console.WriteLine(deger);
            Console.WriteLine("");
            String degisken2 = " ";
            byte b = 5; // 0-255 arası değer. 1 byte yer kaplar
            sbyte c = 5; // -128 ile 127 arası değer. 1 byte yer kaplar.

            short s = 5; // 2 byte yer kaplar -32768den +32767 arası değer
            ushort us = 5; // 2 byte yer kaplar. 0 ile 65365 arası yer kaplar.

            Int16 i16 = 2; // 2 byte
            int i = 2;    // 4 byte. -2,147,483,648 ile 2,147,483,647 arası değer
            Int32 i32 = 2;   // 4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2;   // 4 byte
            long l = 4;    // 8 byte
            ulong ul = 4;  // 8byte


            // Reel Sayılar
            float f = 5;   // 4 byte
            double d = 5;  // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';   // 2 byte
            string str = "Zikriye";  //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            string str1 = "";
            string str2 = null;
            string str3 = string.Empty;
            str3 = "Zikriye Ürkmez";
            string ad = "Zikriye";
            string soyad = "Ürkmez";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10<2;

            // değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // çıktısı 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // çıktısı 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            
        }
    }
} 
