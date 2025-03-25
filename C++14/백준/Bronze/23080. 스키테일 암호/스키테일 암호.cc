#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    string s;
    cin >> a >> s;
    for (int i=0;i<s.length();i+=a){
        cout << s[i];
    }
    return 0;
}