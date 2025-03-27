#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    string s;
    cin >> a >> s;
    for (int i=1;i<a*2;i++){
        if (s[i-1]==s[i]){
            cout << "No";
            break;
        }
        if (i==a*2-1){
            cout << "Yes";
        }
    }
    return 0;
}