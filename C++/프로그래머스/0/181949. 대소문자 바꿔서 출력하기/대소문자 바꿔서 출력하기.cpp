#include <iostream>
#include <string>
using namespace std;

int main(void) {
    string str;
    cin >> str;
    for (int i=0;i<str.length();i++){
        int n = (int)str[i];
        cout << (n<97?(char)(n+32):(char)(n-32));
    }
    return 0;
}