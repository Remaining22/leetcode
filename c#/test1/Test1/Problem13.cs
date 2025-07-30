using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Problem13
    {
        public int RomanToInt(string s)
        {
            int Response = 0;
            int counter = 0;
            IDictionary<char, int> NewNumber = new Dictionary<char, int>();
            NewNumber.Add('M', 1000);
            NewNumber.Add('D', 500);
            NewNumber.Add('C', 100);
            NewNumber.Add('L', 50);
            NewNumber.Add('X', 10);
            NewNumber.Add('V', 5);
            NewNumber.Add('I', 1);
            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (counter <= NewNumber[s[i]])
                {
                    Response += NewNumber[s[i]];
                }
                else if (counter > NewNumber[s[i]])
                {
                    Response -= NewNumber[s[i]];
                }
                counter = NewNumber[s[i]];
            }
            return Response;
        }
    }
}
