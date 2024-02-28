using System;

namespace lessonOne{
    class Program{
        public static void Main(string[] args){
            int deger = 2;
            string degisken = null;
            //string Degisken = null
            //string System = "";
            byte bt = 5;
            sbyte sbt = 5;
            short srt = 5;
            ushort usrt = 5;
            Int16 i16 = 1;
            Int32 i32 = 2;
            Int64 i64 = 3;
            int i = 1;
            uint ui = 2;
            long ln = 1;
            ulong uln = 4;
            float fl = 5.1f;
            double db = 6.2;
            decimal de = 2;

            char ch = 'a';
            string st = "hello";
            bool b1 = true, b2 = false;
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            object o1 = "x";
            object o2 = 4;
            string str1 = string.Empty;
            str1 = "C# Degiskenler";
            string name = "C#";
            string version = "5.0";
            string dotNet = name + " " + version; 
            
            //integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean

            bool bool1=  10>2;

            //Dönüşümler
            string str20 = "20";
            int int20 = 20;


            string newValue = str1 + int20.ToString();
            Console.WriteLine(newValue);
            
            int int21 = int20 + Convert.ToInt32(str20);

            int int22 = int20 + int.Parse(str20);

            //DateTime

            string dtTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dtTime);

            string dtTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dtTime);
            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

         }
    }

}