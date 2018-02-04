using System;
using System.Collections.Generic;
using System.Linq;

namespace Avereger
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNum=true;
            List<int> nums = new List<int>();
            while (isNum)
            {
                Console.Write("Enter a number or any key to calculate an averege number: ");
                string input = Console.ReadLine();
                isNum = int.TryParse(input, out int num);
                if (isNum) nums.Add(num);
                else if (nums.Count > 0) Console.WriteLine($"The averege number is: {nums.Average()}");                
            }
            Console.WriteLine("Bye!");
            Console.ReadLine();
        }
    }
}
