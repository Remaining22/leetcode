using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Problem9
    {
        public bool IsPalindrome(int x)
        {
            string local = x.ToString();
            var reversed = x.ToString().ToCharArray();
            Array.Reverse(reversed);
            string final = new string(reversed);
            if(local == final)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
