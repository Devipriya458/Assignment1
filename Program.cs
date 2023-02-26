

namespace Assignment1
{
    using System;
    public class AreaOfSquare
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Side of Square: ");
            int Side = Convert.ToInt32(Console.ReadLine());
            
            int Area = Side * Side;
            Console.WriteLine($"Area of Square with side {Side} is {Area}");
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
