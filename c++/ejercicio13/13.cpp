//Pass
#include <map>
#include <string>
using namespace std;
class Solution {
public:
  int romanToInt(string s) {
    int total = 0;
    std::map<char, int> convertor = {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    int nexto;
    int current; 
    for (int i = 0; i < s.length(); i++) {
        current = convertor[s[i]];
        nexto = (i+1 < s.length()) ? convertor[s[i+1]] : 0;
        if (current < nexto){
            total -= current;
        }
        else {
            total += current;
        }
    }
    return total;
  }
};
int main() {
  Solution S = *new Solution;
  S.romanToInt("MCMXCIV");
}
