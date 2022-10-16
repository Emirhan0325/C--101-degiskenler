using System;

namespace degisken
{
    class program
    {
        static void Main(string[] args)
        {
            byte b = 5; // 1 byte
            sbyte sb = 5; // 1 byte

            short s = 5; // 2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 2; // 2 byte
            int i = 2; // 4 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 2; // 8 byte
            ulong ul = 2; // 8 byte

            // Reel sayılar
            float f = 5; // 4 byte
            double d = 5; // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2'; // 2 byte
            string str = "Emirhan"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.4;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Emirhan Topal";
            string ad = "Emirhan";
            string soyad = "topal";
            string tamisim = ad + " " + soyad;

            // İnteger tanımlama şekilleri 

            int integer1 = 5;
            int integer2 = 6;
            int integer3 = integer1 * integer2;

            // boolean 

            bool bool1 = 10<2;
            bool bool2 = 10>2;

            // değişken dönüşümleri

            string str10 = "10";
            int int10 = 10;

            string yeniDeger = str10 + int10.ToString();
            Console.WriteLine(yeniDeger);

            int int11 = int10 + Convert.ToInt32(str10);
            Console.WriteLine(int11); // çıktısı 20

            int int12 = int10 + int.Parse(str10); 
            Console.WriteLine(int12); // çıktısı 20

            // Datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

            Console.ReadLine();

            

















            



             

        

        

        }
    }
}