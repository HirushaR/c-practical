using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = int.Parse(Console.ReadLine());

            Class1 ca = new Class1(); // this is creating object
            c =  ca.getsum(a,b); // use the getsum method in class1
            Console.WriteLine("" + c);
            Console.ReadLine();

        }
    }

   
}
