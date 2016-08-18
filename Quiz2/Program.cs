using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int origPin = 123456;
            Console.WriteLine("welcome to the bank of Iss");
            Console.Write("Enter your PIN:");
            String input = Console.ReadLine();
            int pin = Convert.ToInt32(input);
            int i = 1;
            while(pin != origPin)
            {
                if (i == 3)
                {
                    Console.WriteLine("Too many wrong PIN Entries.Your account is knocked.");
                    return;
                }
                Console.WriteLine("Incorrect PIN.Try again");
                Console.Write("Enter your PIN:");
                input = Console.ReadLine();
                pin = Convert.ToInt32(input);
                i++;
            }
            if (pin == origPin)
            {
                Console.WriteLine("PIN accepted.");
            }
        }
    }
}
