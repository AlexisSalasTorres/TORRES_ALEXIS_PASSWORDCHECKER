using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TORRES_ALEXIS_PASSWORDCHECKER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();

            bool isStrong = password.Length >= 8 &&
                            HasUppercase(password) &&
                            HasLowercase(password) &&
                            HasDigit(password) &&
                            HasSpecialCharacter(password);
            Console.WriteLine(isStrong ? "Password is Strong" : "Password is Weak");
            Console.ReadLine();
        }
        static bool HasUppercase(string input) => input != input.ToLower();
        static bool HasLowercase(string input) => input != input.ToUpper();
        static bool HasDigit(string input) => input.Any(char.IsDigit);
        static bool HasSpecialCharacter(string input) => input.Any(ch => !char.IsLetterOrDigit(ch));
        
    }
   

}
