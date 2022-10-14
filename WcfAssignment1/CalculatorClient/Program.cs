using CalculatorClient.CalculatorReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CalculatorClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorReference.FiveMethodServiceClient client = new CalculatorReference.FiveMethodServiceClient();
            string choice = "";
            while (!choice.Equals("6"))
            {
                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("1. Prime Number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\tEnter your choice: ");

                choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Prime Number");
                        int pNumber;

                        Console.WriteLine("Enter number:");
                        pNumber = Convert.ToInt32(Console.ReadLine());

                        if (client.IsPrime(pNumber))
                        {
                            Console.WriteLine("prime number");
                        }
                        else
                        {
                            Console.WriteLine("not a prime number");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Sum of digits\t");
                       
                        Console.Write("Enter the Number : ");
                        int sumNum = int.Parse(Console.ReadLine());
                        int theSum = client.SumOfDigits(sumNum);
                        Console.WriteLine($"{theSum}");
                        break;

                    case "3":
                        Console.WriteLine("Reverse a string");
                        Console.Write("Enter a string : ");
                        string rstring = Console.ReadLine();
                        string thestring = client.Reverse(rstring);
                        Console.WriteLine($"{thestring}");
                        break;

                    case "4":
                        Console.WriteLine("HTML Tag");
                        Console.Write("Enter a HTML Tag : ");
                        string tagstring = Console.ReadLine();
                        Console.Write("Enter Data : ");
                        string txtstring = Console.ReadLine();
                        string htmlstring = client.HTMLTag(tagstring, txtstring);
                        Console.WriteLine($"{htmlstring}");
                        break;

                    case "5":
                        Console.WriteLine("Sort 5 numbers");
                        Console.Write("Enter Ascending or Descending : ");
                        string sortstring = Console.ReadLine();
                        Console.Write("Enter a 5 numbers : ");
                        int sortNum1 = int.Parse(Console.ReadLine());
                        int sortNum2 = int.Parse(Console.ReadLine());
                        int sortNum3 = int.Parse(Console.ReadLine());
                        int sortNum4 = int.Parse(Console.ReadLine());
                        int sortNum5 = int.Parse(Console.ReadLine());
                        string resultstring = client.SortNumbers(sortstring, sortNum1, sortNum2, sortNum3, sortNum4, sortNum5);
                        Console.WriteLine($"{resultstring}");
                        break;

                    case "6":
                        
                        break;
                }

            }           
        }
    }
}
