using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAssignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FiveMethodService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FiveMethodService.svc or FiveMethodService.svc.cs at the Solution Explorer and start debugging.
    public class FiveMethodService : IFiveMethodService
    {
        public bool IsPrime(int primeNumber)
        {
            if (primeNumber <= 1) return false;
            if (primeNumber == 2) return true;
            if (primeNumber % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(primeNumber));

            for (int i = 3; i <= boundary; i += 2)
                if (primeNumber % i == 0)
                    return false;

            return true;
        }

        public int SumOfDigits(int sumNumber)
        {
            if (sumNumber != 0)
            {
                return (sumNumber % 10 + SumOfDigits(sumNumber / 10));
            }
            else
            {
                return 0;
            }
        }

        public string Reverse(string sReverse)
        {
            char[] reverseArray = sReverse.ToCharArray();
            Array.Reverse(reverseArray);
            return new string(reverseArray);
        }

        public string HTMLTag(string tag, string txt)
        {
            return $"<{tag}>{txt}</{tag}>";
        }

        public string SortNumbers(string sortType, int num1, int num2, int num3, int num4, int num5)
        {
            int[] sortArray = { num1, num2, num3, num4, num5 };
            Array.Sort(sortArray);
            if (sortType == "Descending")
            {
                Array.Reverse(sortArray);
            }
            return $"{sortArray[0]},{sortArray[1]},{sortArray[2]},{sortArray[3]},{sortArray[4]}";
        }


    }
}