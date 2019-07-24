using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Rajveer Kaur");

            Console.Write("Enter number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Sum(num1, num2));
            Console.WriteLine($"The division of the two numbers is :{Div(num1, num2)}");
            Console.WriteLine(Multiply(num1, num2));

            Console.WriteLine();

            Console.WriteLine("Enter a number to view its table:");
            int input = int.Parse(Console.ReadLine());

            /*using for loop
            for(int i=1; i<11; i++)
            { Console.WriteLine($"{input} x {i} = {input * i}"); }*/

            //using do while loop
            int counter = 1;
            do {
                Console.WriteLine($"{input} x {counter} = {input * counter}");
                counter++;
            }
            while (counter < 11);

            Console.WriteLine();

            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Perimeter of circle is: {Perimeter(radius)}");
            Console.WriteLine($"The Area of circle is: {Area(radius)}");




            Console.ReadLine();
        }
        static string Sum(double num1, double num2)
        { return $" {num1} + {num2} =  {num1 + num2} ";}

        static double Div(double num1, double num2)
        { return num1/num2; }

        static string Multiply(double num1, double num2)
        { return $" {num1} x {num2} =  {num1 * num2} "; }

        static double Perimeter(double radius)
        { return Math.PI * 2 * radius; }

        static double Area(double radius)
        { return Math.PI * radius * radius; }

    }
}
