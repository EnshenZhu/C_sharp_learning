using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findTheMissingNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 2, 3, 10 };
            FindTheMissingNum(arr1).ForEach(num => Console.Write(num + ","));
            Console.WriteLine();

            int[] arr2 = { 3 };
            FindTheMissingNum(arr2).ForEach(num => Console.Write(num + ","));
            Console.WriteLine();

            int[] arr3 = { };
            FindTheMissingNum(arr2).ForEach(num => Console.Write(num + ","));
            Console.WriteLine();

            int[] arr4 = { 4, 2, 3 };
            FindTheMissingNum(arr4).ForEach(num => Console.Write(num + ","));
            Console.WriteLine();

            int[] arr5 = { 2, 2, 2, 2, 3 };
            FindTheMissingNum(arr5).ForEach(num => Console.Write(num + ","));
            Console.WriteLine();

            int[] arr6 = { 3, 12, 9 };
            FindTheMissingNum(arr6).ForEach(num => Console.Write(num + ","));
            Console.WriteLine();

            Console.ReadLine();
        }

        static List<int> FindTheMissingNum(int[] inputArr)
        {
            List<int> result = new List<int>();

            if (inputArr.Length > 1 && inputArr != null)
            {
                Dictionary<int, int> Dict = new Dictionary<int, int>(); // create an empty hashset  

                for (int i = 0; i < inputArr.Length; i++) // store the relative position of every single unit from the inputArr
                {
                    Dict[inputArr[i]] = i;
                }

                bool missNumber = false; // the inputArr is by default not missing any number

                for (int j = inputArr.Min(); j <= inputArr.Max(); j++)

                // j is the iterator between the minimum number and the maximum number between the inputArr
                // for example, if min=4 and max=10, j will iterate between 4 to 10
                {
                    if (Dict.ContainsKey(j)==false) // if the iterated j cannot be found in the previous hashset, the value of j is the missing number among the input array.
                    {
                        result.Add(j);
                        missNumber = true;
                    }
                }

                if (missNumber==false) // if there are no missing numbers, the result list will only have one element of zero
                {
                    result.Add(0);
                }
            }
            else
            {
                result.Add(0); // if the inputArr only has one element or is null, the result list will only have one element of zero
            }

            return result;
        }
    }
}
