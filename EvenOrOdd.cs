using System;


namespace Assignment1
{
   class EvenOrOdd
    {
        static void main(string[] args)
        {
            int number, remainder;
            Console.WriteLine("Pls Enter an Integer Value");
            number = Convert.ToInt32(Console.ReadLine());
            remainder = number % 2;
            if (remainder == 0)
            
                Console.WriteLine("{0} is an Even number", number);
            else
                 Console.WriteLine("{0} is an Odd number", number);
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                
            
        }
    }
}
