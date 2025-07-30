// Passed
#include <iostream>
#include <string.h>
#include <string>
using namespace std;
class Solution {
public:
  string makeFancyString(string s) {
    string result;
    char chararray[s.length() + 1];
    char counter = ' ';
    int repeats;
    strcpy(chararray, s.c_str());
    for (int i = 0; i < s.length(); i++) {
      if (counter != chararray[i]) {
        repeats = 0;
        counter = chararray[i];
      }
      if (repeats < 2) {
        result.append(1, chararray[i]);
        repeats++;
      }
    }
    cout << result;
    return result;
  }
};
int main() {
  Solution S = *new Solution;
  S.makeFancyString("Leeeetcodeeee");
  return 0;
}
