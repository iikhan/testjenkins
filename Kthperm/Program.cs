using System;
using System.Text;

namespace Kthperm
{
    class Program
    {
        
        static string FindKthPerm(string number, int k)
        {
            //ciinet
            //1234
            //12345
            //123
            int[] factArray = new int[number.Length+1];
            factArray[0] = 1;
            for (int i = 1; i <= number.Length; i++)
                factArray[i] = i * factArray[i - 1];

            StringBuilder builder = new StringBuilder();

            while (number.Length > 0)
            {
                int partLength = factArray[number.Length] / number.Length;
                //4!/4 = 6
                int n = k / partLength;


                builder.Append(number[n]);

                number = number.Replace(number[n].ToString(), "");

               
                k = k % partLength;

            }

            return builder.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindKthPerm("1234", 15));

         //   Console.WriteLine("Hello World!");
        }
    }
}
