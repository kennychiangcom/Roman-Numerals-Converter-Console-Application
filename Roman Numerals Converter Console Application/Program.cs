// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Enter Roman numerals: ");

string num = Console.ReadLine().ToUpper().Trim();
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
            Console.WriteLine("The Roman numerals you entered are invalid - please revise.");
            return;
    }
}
for (int i = 0; i < numValue.Length - 1; i++)
{
    if (numValue[i] < numValue[i + 1]) numValue[i] = -numValue[i];
}
Console.WriteLine(numValue.Sum());
