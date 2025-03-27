#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    string s;
    cin >> a;
    getline(cin,s);
    for (int i=0;i<a;i++){
        getline(cin,s);
        for (int j=s.size()-1;j>=0;j--){
            cout << s[j];
        }
        cout << '\n';
    }
    return 0;
}