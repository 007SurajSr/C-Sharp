using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        //static void Greet( string name)
        //{
        //    Console.WriteLine(" Good Morning " + name );
        //}

        //static float Average(int a, int b, int c)
        //{
        //    float sum = a + b + c;
        //    return sum / 3;
        //}

        //static float Average1(float a, float b )
        //{
        //    return (a + b ) / 3;
        //}



            static void Main(string[] args)
            {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("My name is Suraj and currently I'm learning C# on the .Net developing plateform");
            //int suraj = 21;
            //int a = 56;
            //float f = 34.2F;
            //double d = 57.24D;
            //bool b = true;
            //char c = 'r';
            //string s = "this is the string";
            //int x = (int)3.5;
            //int y = 3;
            //double d1 = y;
            //int z = 'y';

            //float varr = Convert.ToInt32(3.55);

            //string sx = "Random string"; 

            //Console.WriteLine(suraj);
            //Console.WriteLine(f);
            //Console.WriteLine(d);   
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(s);  
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(d1);
            //Console.WriteLine(varr);
            //Console.WriteLine(sx);

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("hey!!! Hello " + name);
            //Console.WriteLine("How many candies do you want ? ");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(can) + 4));

            //int a = 4;
            //int b = 2;
            //Console.WriteLine("The value of a+b is:" + (a + b));

            //int c = 3;
            //int c2 = c;
            //c2 += 7;
            //c -= -2;
            //b /= 2;
            //a *= 5;
            //Console.WriteLine(c2);
            //Console.WriteLine(c);
            //Console.WriteLine(b);
            //Console.WriteLine(a);


            //Act live AND gate

            //Console.WriteLine(true && false);
            //Console.WriteLine(false && false);
            //Console.WriteLine(true && true);

            ////Act live OR gate

            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);


            ////Act live NOT gate

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);


            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);

            //int a = Math.Max(16, 39);
            //int a1= Math.Min(16, 36);
            //double a2 = Math.Abs(a);
            //double a3 = Math.Sqrt(a);

            //Console.WriteLine(a);
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.WriteLine(a3);

            //string hello = "Hello world! this is Suraj ";
            //Console.WriteLine(hello);
            //Console.WriteLine(hello[11]);
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower()); 
            //Console.WriteLine(hello.IndexOf("is"));
            // Console.WriteLine(hello.Substring(5)); 
            //Console.WriteLine(hello + "You are Great");
            //Console.WriteLine(string.Concat(hello,"You are awesome"));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}, You will get {candies} candies");


            //string n = Console.ReadLine();
            //int age = Convert.ToInt32(n);
            //if (age > 18)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else if
            //    (age < 10)
            //{
            //    Console.WriteLine("Please finish your high school first");
            //}
            //else if
            //    (age < 18)
            //{
            //    Console.WriteLine("You are below 18");
            //}
            //else
            //{
            //    Console.WriteLine("You can not drive any Vehile in India.");
            //}

            //string age = Console.ReadLine();
            //int ageStr = Convert.ToInt32(age);

            //bool isBanned = false;

            //if (ageStr < 2 || isBanned)
            //{
            //    Console.WriteLine("You are just born or banned");
            //}
            //else if (ageStr < 10 || isBanned)
            //{
            //    Console.WriteLine("Please finish your high school or may be you are banned");
            //}
            //else if (ageStr < 18 ) 
            //{
            //    Console.WriteLine("You are below 18");
            //}
            //else if (ageStr < 25)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("you can not drive");
            //}

            //string age = Console.ReadLine();
            //int ageStr = Convert.ToInt32(age);

            // switch (ageStr)
            // {
            //     case 18:
            //         Console.WriteLine("Please wait for one year");
            //         break;

            //     case 20:
            //         Console.WriteLine("You are 20");
            //         break;

            //     default:
            //           Console.WriteLine("Enjoy!!");
            //         break;
            // }



            //loops

            // int i = 0;
            //while (i < 1001)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i < 5);

            //for (float i=0; i < 10; i++)
            //{
            //    Console.WriteLine(i + 1);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i + 1);
            //    break;
            //}

            //Greet("Suraj");
            //Console.WriteLine(Average1(55,  3));
            //Console.WriteLine(Average(5,7,3));

            Player tommy = new Player();
            Console.WriteLine(tommy.gethealth());
            tommy.setHealth(56);
            Console.WriteLine(tommy.gethealth());
            Console.ReadLine();
           
        }
    }
}
