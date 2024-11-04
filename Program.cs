using System;

namespace ALBRIGHT_ASSIGNMENT_1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.1.1. SOLUTION:

            Console.WriteLine("Please enter your name:");
            string Name_String = Console.ReadLine();
            Console.WriteLine("\nNow please enter your Age in decimal format:");
            double Age_Double = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nFinally, please enter your address");
            string Address_String = Console.ReadLine();
  
            Console.WriteLine("\nThanks! I record that your name is " + Name_String + ", you are " + Age_Double + " years old, and reside @ " + Address_String);

           
        }
    }
}
