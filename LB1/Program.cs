using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = true;
            bool b2 = false;
            //bool b3 = 0; не удается неявно преобразовать тип int в bool

            byte by1 = 255;
            byte by2 = 0;
            //byte by3 = 256;   тип byte может хранить значения в интервале от 0 до 255 
            //byte by4 = -1;
            //byte by5 = 0.1;   byte- целочисленный тип данных

            char ch1 = 'd'; 
            //char ch2 = 'dss'; char может хранить только один символ в одинарных кавычках
            //char ch3 = 111;


            decimal de1 = 123;
            //decimal de2 = 123123.23312M * 1.25;  нельзя операнд "*" применить к типам decimal и double
            decimal de3 = 123123.23312M * 1.25M;

            

            int a = 2147483647;
            int b = -2147483648;
            //int c = 2147483648; тип int может хранить целочисленные значения только от -2147483648 до 2147483647
            //int d = -2147483649;

            float fl1 = 10.1f;
            //float fl2 = 10.1f * de1; decimal de2 = 123123.23312M * 1.25;  нельзя операнд "*" применить к типам float и double
            float fl2 = a * 3;
           

            double do1 = 213123312.12312;
            double do2 = 3 * by2;
            double db1 = fl1 / 3;

            //float fl3 = db1 * 4.0; // не преобразуется
            //byte bt1 = a * 2;

            long l1 = 9223372036854775807;
            //long l2 = 9223372036854775808;  тип long может хранить целочисленные значения только от -9223372036854775808 до 9223372036854775807
            long l3 = -9223372036854775808;
            //long l4 = -9223372036854775809;
            long l5 = 19 * a;

            sbyte sb1 = -128;
            //sbyte sb4 = -129;   тип sbyte может хранить целочисленные значения только от -128 до 127
            sbyte sb2 = 127;
            //sbyte sb3 = 128;

            short sh1 = 32767;
            //short sh2 = 32768; тип short может хранить целочисленные значения только от -32768 до 32767
            short sh3 = -32768;
            //short sh4 = -32769;

            uint ui1 = 0;
            //uint ui1 = -1;
            uint ui2 = 4294967295;
            //uint ui2 = 4294967296; тип short может хранить целочисленные значения только от 0 до 4294967295

            ulong ul1 = 0;
            // ulong ul2 = -1; тип ulong может хранить целочисленные значения только от 0 до 18446744073709551615
            ulong ul3 = 18446744073709551615;
           // ulong ul4 = 18446744073709551616;

            ushort us1 = 0;
            //ushort us2 = -1;
            ushort us3 = 65535;
            //ushort us4 = 65536; тип ulong может хранить целочисленные значения только от 0 до 65536

            Console.WriteLine("bool: " + b1);
            Console.WriteLine("bool: " + b2);
            Console.WriteLine("byte: " + by1);
            Console.WriteLine("byte: " + by2);
            Console.WriteLine("char: " + ch1);
            Console.WriteLine("decimal: " + de1);
            Console.WriteLine("decimal: " + de3);
            Console.WriteLine("double: " + do1+";"+ db1);
            Console.WriteLine("decimal: " + do2);
            Console.WriteLine("float: " + fl1+";" + fl2);
            Console.WriteLine("int: " + a);
            Console.WriteLine("int: " + b);
            Console.WriteLine("long: " + l1);
            Console.WriteLine("long: " + l3);
            Console.WriteLine("long: " + l5);
            Console.WriteLine("sbyte: " + sb1);
            Console.WriteLine("sbyte: " + sb2);
            Console.WriteLine("short: " + sh1);
            Console.WriteLine("short: " + sh3);
            Console.WriteLine("uint: " + ui1);
            Console.WriteLine("uint: " + ui2);
            Console.WriteLine("ulong: " + ul1);
            Console.WriteLine("ulong: " + ul3);
            Console.WriteLine("ushort: " + us1);
            Console.WriteLine("ushort: " + us3);
            Console.WriteLine("\nЗадание 2:");




            int[] arr = new int[10];
            int k = 9;
            Console.WriteLine("Четные числа: ");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = k;
                k++;
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine("Числа от 0 до 4: ");
            int j = 0;
            while (j < 5)
            {
                switch (j)
                {
                    case 0:
                        Console.WriteLine("j=0");
                        j++;
                        break;
                    case 1:
                        Console.WriteLine("j=1");
                        j++;
                        break;
                    case 2:
                        Console.WriteLine("j=2");
                        j++;
                        break;
                    case 3:
                        Console.WriteLine("j=3");
                        j++;
                        break;
                    case 4:
                        Console.WriteLine("j=4");
                        j++;
                        break;

                }

            }
            Console.WriteLine("Четные и нечетные числа от 1 до 10 ");
            int y = 1;
            do
            {
                if (y % 2 == 1)
                {
                    Console.WriteLine("число " + y + "- нечетное число");
                    y++;
                }
                else
                {
                    Console.WriteLine("число " + y + "- четное число");
                    y++;
                }

            }
            while (y < 11);



            
            static int TTR(int i)
            {
                i = 3 * 3 * 3 * i;
                return i;
            }
            static int TTR1(ref int  i)
            {
                i = 3 * 3 * 3 * i;
                return i;
            }

            int ttr2;
            static  void TTR2(out int ttr2)
            {
                ttr2 = 10;
                ttr2++;
            }
            int abc = 2;
            Console.WriteLine("\nЗадание 3:");
            Console.WriteLine("Значение abc = " + abc);
            Console.WriteLine("Передача аргументов по значению: "+TTR(abc));
            Console.WriteLine("Значение abc после передачи аргумента по значению: " + abc);
            Console.WriteLine("Передача аргументов по ссылке: " + TTR1(ref abc));
            Console.WriteLine("Значение abc после передачи аргумента по ссылке: " + abc);
            Console.WriteLine("Передача аргументов по ссылке out: ");
            TTR2(out ttr2);
            Console.WriteLine("Значение ttr2 после передачи аргумента по ссылке: " + ttr2);



            Console.ReadLine();
        }
    }
}
