using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszyplik
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("wsb");
            //Console.WriteLine("Nowa Linia");

            //Console.Write("Proszę podaj swoje imię: ");
            //string name = Console.ReadLine();
            ////typ string

            //Console.Write("Masz na imię: ");
            //Console.WriteLine(name);

            ////typ integer
            //int age = 23;
            //Console.WriteLine(age);

            //uint numer = 10;

            ////typ float
            //float z = 14.55F;
            ////+ konkatenacja
            //Console.WriteLine("Zmienna z wynosi: " + z);

            //Console.WriteLine("Program obliczający pole prostokąta");
            //Console.WriteLine("Podaj a: ");
            //string aIn = Console.ReadLine();
            //float a = float.Parse(aIn);
            //Console.WriteLine("Podaj b: ");
            //string bIn = Console.ReadLine();
            //float b = float.Parse(bIn);
            //Console.WriteLine("Pole prostokąta wynosi: " + a*b);


            //Console.WriteLine("Program obliczający pole prostokąta");
            //Console.WriteLine("Podaj a: ");
            //string x = Console.ReadLine();
            //x = float.Parse(x);
            //To jest błędny kod

            Console.WriteLine("Program obliczający pole prostokąta");
            Console.WriteLine("Podaj a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Pole prostokąta wynosi: " + a * b);


            int x, y = 10, l;

            //int zmienna = 10;
            int zmienna = new int();



            Console.ReadKey();

        }
    }
}
