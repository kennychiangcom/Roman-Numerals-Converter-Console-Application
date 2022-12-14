// See https://aka.ms/new-console-template for more information

namespace RomanNumeralsConverter
{
    public class RomanNumeralsConverter
    {
        public static void Main()
        {
            Console.WriteLine("Enter Roman numerals: ");
            int num = RConvert(Console.ReadLine());
            if (num == -1) Console.WriteLine("The Roman numerals you entered are invalid - please revise.");
            else Console.WriteLine(num);
        }

        public static int RConvert(string num)
        {
            num = num.ToUpper().Trim();
            if (num.Contains("IIII")) return -1;
            else if (num.Contains("VV")) return -1;
            else if (num.Contains("XXXX")) return -1;
            else if (num.Contains("LL")) return -1;
            else if (num.Contains("CCCC")) return -1;
            else if (num.Contains("DD")) return -1;
            else if (num.Contains("MMMM")) return -1;

            int[] numValue = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                switch (num.Substring(i, 1))
                {
                    case "M":
                        numValue[i] = 1000;
                        break;
                    case "D":
                        numValue[i] = 500;
                        break;
                    case "C":
                        numValue[i] = 100;
                        break;
                    case "L":
                        numValue[i] = 50;
                        break;
                    case "X":
                        numValue[i] = 10;
                        break;
                    case "V":
                        numValue[i] = 5;
                        break;
                    case "I":
                        numValue[i] = 1;
                        break;
                    default:
                        return -1;
                }
            }
            for (int i = 0; i < numValue.Length - 1; i++)
            {
                if (numValue[i] < numValue[i + 1]) numValue[i] = -numValue[i];
            }
            return numValue.Sum();
        }
    }
}