using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Problem412
    {
        public IList<string> FizzBuzz(int n) {
            string[] response = new string[n];
            for (int i = 1; i < n+1; i++)
            {
                if(i%3==0 || i%5==0 && i!=0)
                {
                    if(i % 3 == 0)
                    {
                        response[i-1] += "Fizz";
                    }
                    if(i % 5 == 0)
                    {
                        response[i-1] += "Buzz";
                    }
                }
                else
                {
                    response[i-1] = $"{i}";
                }
            }
            return response;
        }
    }
}
