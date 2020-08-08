using System;
using System.Diagnostics;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwhatch= new Stopwatch();
            stopwhatch.Start();
            int num = 10;
            var x = (object) num;
            int result = (int) x;
            TimeSpan a = stopwhatch.Elapsed; 
            Console.WriteLine($"Время выполнения перопределния {stopwhatch.Elapsed}");
            stopwhatch.Reset();
            TimeSpan b = stopwhatch.Elapsed; 
            int result2 = num;
            Console.WriteLine($"Время выполнения присвоения {stopwhatch.Elapsed}");
            if (a > b)
            {
                Console.WriteLine("Значит код работает медленнее\r\nint num = 10;\r\nvar x = (object) num;\r\nint result = (int) x; ");
            }
            else
            {
                Console.WriteLine("Значит код работает медленнее \r\n int result = num; ");
            }
            stopwhatch.Stop();
            
            var stopStructClass=new Stopwatch();
            stopStructClass.Start();
            var clas =new MyClass(false,125,32767,255,127,'c',3.56,(float)3.56,4294967295,9223372036854775807,18446744073709551615,65535,"Тест");
            var speed = clas;

            speed.String = "Текс2";
            Console.WriteLine(clas.String);
            Console.WriteLine(speed.String);
            Console.WriteLine($"Инициализация класса {stopStructClass.Elapsed}");
            var test2 = (MyClass) null; // Можно указать привести к классу Null


           
            stopStructClass.Reset();
            var struc=new MyStruct(false,125,32767,255,127,'c',3.56,(float)3.56,4294967295,9223372036854775807,18446744073709551615,65535,"Тест");
            var SpeedClass = struc;
         
            SpeedClass.String = "Тест2";
            Console.WriteLine(struc.String);
            Console.WriteLine(SpeedClass.String);
             // var test1 = (MyStruct)null; //Нельзя привести структуру к Null
             
            Console.WriteLine($"Инициализация структуры {stopStructClass.Elapsed}");

            

        }
         
        public class MyClass
        {
            public bool TrueOrFalse;
            public int Id;
            public short ShortNum;
            public byte Byte;
            public sbyte Sbyte;
            public char Char;
            public double Double;
            public float Float;
            public uint Unit;
            public long LongNum;
            public ulong UlongInt;
            public ushort UshortNum;
            public string String;

            MyClass()
            {
                
            }

            public MyClass(bool trueOrFalse, int id, short shortNum, byte b, sbyte @sbyte, char c, double d, float f, uint unit, long longNum, ulong ulongInt, ushort ushortNum, string s)
            {
                TrueOrFalse = trueOrFalse;
                Id = id;
                ShortNum = shortNum;
                Byte = b;
                Sbyte = @sbyte;
                Char = c;
                Double = d;
                Float = f;
                Unit = unit;
                LongNum = longNum;
                UlongInt = ulongInt;
                UshortNum = ushortNum;
                String = s;
            }
        }
        public struct MyStruct
        {
            public bool TrueOrFalse;
            public int Id;
            public short ShortNum;
            public byte Byte;
            public sbyte Sbyte;
            public char Char;
            public double Double;
            public float Float;
            public uint Unit;
            public long LongNum;
            public ulong UlongInt;
            public ushort UshortNum;
            public string String;

            public MyStruct(bool trueOrFalse, int id, short shortNum, byte b, sbyte @sbyte, char c, double d, float f, uint unit, long longNum, ulong ulongInt, ushort ushortNum, string s)
            {
                TrueOrFalse = trueOrFalse;
                Id = id;
                ShortNum = shortNum;
                Byte = b;
                Sbyte = @sbyte;
                Char = c;
                Double = d;
                Float = f;
                Unit = unit;
                LongNum = longNum;
                UlongInt = ulongInt;
                UshortNum = ushortNum;
                String = s;
            }
        }
    }
  

}