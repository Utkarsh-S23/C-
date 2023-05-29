using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Program
    {
        static void greet(string name)
        {
            Console.WriteLine("good  morning " + name);
        }

        static float average(int a, int b,int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }

        static float average(int a, int b)
        {
            return (a + b) / 2;
        }

        static void Main(string[] args)
        {
            /* this is important debug,
            do not remove.
            */
            /*
            int a = 12;
                // data types: int,long,float,double,char='X',bool,string inp="Xy" ;
            Console.WriteLine("your name ?");
            string b=Console.ReadLine();
            Console.WriteLine("heyy " +b);
            Console.WriteLine("how many candles ?");
            string b1=Console.ReadLine();
            Console.WriteLine("you'll get 2 more candles as: " + (Convert.ToInt64( b1 ) +2));

            Console.Write("hello everyone - ");
            Console.WriteLine("how's it going");
            Console.WriteLine("here it is c# and the no. "+a);
            Console.ReadLine();
            */
            /*
            int a = 12;
            float b = 10.69F;
            double c = 30.2D;
            bool d = false; 
            char e = 'a';   
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(a + b + c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadLine();
            */

            // type casting: implicit casting: char to int to long to float to double;
            /*
            int a = 3;
            double b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
            */

            //explicit casting;
            /*
            int a = (int)3.5;
            Console.WriteLine(a);
            Console.ReadLine();
            */

            //also type casting method;
            /*
            float varr = Convert.ToInt32(10.9);
            Console.WriteLine(varr);
            Console.ReadLine();
            */

            // operators: arithmetic,assignment,logical,comparison;
            /*
            int a = 10;
            int b = 100;
            Console.WriteLine(a+b);
            Console.ReadLine();  
            */

            /*
            int a = 4; int b = a;
            b += 4;
            Console.WriteLine("b= " + b );
            Console.ReadLine();
            */

            /*
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);
            //Console.WriteLine(32>55);
            //Console.WriteLine(32<55);
            //Console.WriteLine(32<=55);
            //Console.WriteLine(32!=55);
            //Console.WriteLine(32==32);
            Console.ReadLine(); 
            */

            /*
            //int a = Math.Max(32, 11);
            //double a = Math.Sqrt(11);
            double b = Math.Round(39.5);
            Console.WriteLine(b);
            Console.ReadLine();
            */

            /*
            string h = "hii";
            Console.WriteLine(h.Length);
            Console.WriteLine(h.ToUpper());
            //Console.WriteLine(h + " you are nice");
            Console.WriteLine(string.Concat(h," you are nice"));
            Console.ReadLine(); 
            */

            /*
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            //string interpolation
            Console.WriteLine($"your name is { a }, and you'll get { b } candies");
            Console.ReadLine();
            */

            /*
            string h = "hello, \n how r\" you ?";
            Console.WriteLine(h[1]);
            Console.WriteLine(h.IndexOf("how"));
            Console.WriteLine(h.Substring(4));
            Console.WriteLine(h);
            Console.ReadLine(); 
            */

            /*
            Console.WriteLine("enter age");
            string agestr=Console.ReadLine();
            int age = Convert.ToInt32(agestr);
            if (age < 2 )
            {
                Console.WriteLine("u r just born");
            }
            else if (age < 10 )
            {
                Console.WriteLine("finish your high school first");
            }
            else
            {
                Console.WriteLine("u can drive");
            }
            Console.ReadLine(); 
            */

            /*
            int age = 18;
            switch (age)
            {
                case 18:
                    Console.WriteLine("wait for a year");
                    break;  
                case 20:
                    Console.WriteLine("u r 20");
                    break;
                default:
                    Console.WriteLine("enjoy!");
                    break;
            }
            Console.ReadLine(); 
            */

            /*
            // loops
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}
            //Console.ReadLine();

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i > 5);
            //Console.ReadLine();
            
            for (int i = 0; i < 5; i++)
            {     //break nd continue
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(i + 1);
                //break;
                //continue;
            }
            Console.ReadLine();
            */

            /*
            // methods nd functions
            greet("arun");
            greet("raj");
            Console.WriteLine(average(2,6,9));
            float temp = average(9, 6, 3);
            Console.WriteLine(temp);
            Console.WriteLine(average(2, 6));
            Console.ReadLine();
            */

            // oops classes nd objects
            Class1 andy = new Class1();
            //Console.WriteLine("previous health: " +andy.health);
            andy.setHealth(57);
            //Console.WriteLine("new health: " +andy.health);
            Console.WriteLine("private health: " +andy.getHealth());
            Console.ReadLine();
        }
    }
}
