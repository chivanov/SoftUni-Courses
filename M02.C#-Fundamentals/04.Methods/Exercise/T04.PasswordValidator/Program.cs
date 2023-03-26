using System;

namespace T04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            const int passwordMinLength = 6;
            const int passwordMaxLength = 10;
            const int minDigitsCount = 2;

            bool isPasswordValid = ValidatePassword(password, passwordMinLength, passwordMaxLength, minDigitsCount);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidatePassword(string password, int passwordMinLength, int passwordMaxLength, int minDigitsCount)
        {          

            bool isValid = true;

            if (!ValidateLength(password, passwordMinLength, passwordMaxLength))
            {
                Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters");
                isValid = false;    
            }

            if (!ValidateIfDigitAndLetters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!ValidateMinDigitCount(password, minDigitsCount))
            {
                Console.WriteLine($"Password must have at least {minDigitsCount} digits");
                isValid = false;
            }

            return isValid;

        }

        static bool ValidateLength(string password, int minLength, int maxLength)
        {
            if (password.Length >= minLength && password.Length < maxLength)
            {
                return true;
            }
            return false;   
        }

        static bool ValidateIfDigitAndLetters(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }               
            }
            return true;
        }

        static bool ValidateMinDigitCount(string password, int minDiditsCont)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }                
            }
            return digitsCount >= minDiditsCont;
        }

      
    }
}
