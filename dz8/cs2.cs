using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    struct Decimal_Number
    {
        

        public static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return "0";
            }

            string binaryString = string.Empty;

            while (decimalNumber > 0)
            {
                binaryString = (decimalNumber % 2) + binaryString;
                decimalNumber /= 2;
            }

            return binaryString;
        }

        // Метод для переведення десяткового числа в вісімкову систему числення
        public static string DecimalToOctal(int decimalNumber)
        {
            if (decimalNumber == 0)
            {
                return "0";
            }

            string octalString = string.Empty;

            while (decimalNumber > 0)
            {
                octalString = (decimalNumber % 8) + octalString;
                decimalNumber /= 8;
            }

            return octalString;
        }

        // Метод для переведення десяткового числа в шістнадцяткову систему числення
        public static string DecimalToHexadecimal(int decimalNumber )
        {
            if (decimalNumber == 0)
            {
                return "0";
            }

            string hexString = string.Empty;
            char[] hexDigits = "0123456789ABCDEF".ToCharArray();

            while (decimalNumber > 0)
            {
                int hexIndex = (decimalNumber % 16);
                hexString = hexDigits[hexIndex] + hexString;
                decimalNumber /= 16;
            }   

            return hexString;
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            int number = 12;

            string binary = Decimal_Number.DecimalToBinary(number);
            Console.WriteLine($"Binary: {binary}");

            string octal = Decimal_Number.DecimalToOctal(number);
            Console.WriteLine($"Octal: {octal}");

            string hexadecimal = Decimal_Number.DecimalToHexadecimal(number);
            Console.WriteLine($"Hexadecimal: {hexadecimal}");
            Console.WriteLine();
        }
    }
}
