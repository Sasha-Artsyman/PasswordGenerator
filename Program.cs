using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght0 = 0;
            // prompt for length input
            Console.Write("Enter password length (recommended 4+): ");
            lenght0 = Convert.ToInt32(Console.ReadLine());
            // length check and output
            if (lenght0 < 4)
            {
                Console.WriteLine("Too short length!");
            }
            else
            {
                PassGener(lenght0);
            }
            Console.ReadLine();
        }
        static void PassGener(int len)
        {
            string UperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowerCase = "abcdefghijklmnopqrstuvwxyz";
            string Nums = "0123456789";
            string Symb = "&?!-_@#";
            Random rnd = new Random();
            string passgener = UperCase + LowerCase + Nums + Symb;
            Console.Write("Your new password: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(passgener[rnd.Next(passgener.Length)]);
            }
        }
    }
}