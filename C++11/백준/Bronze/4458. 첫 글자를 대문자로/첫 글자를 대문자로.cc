#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    string g;
    cin >> a;
    getline(cin,g);
    for (int i=0;i<a;i++){
        string s;
        getline(cin,s);
        cout << (char)toupper(s[0]) <<s.substr(1) << endl;
    }
    return 0;
}