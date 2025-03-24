#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    string s;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> s;
        if (s.size()>=6 && s.size()<=9){
            cout << "yes\n";
        }
        else{
            cout << "no\n";
        }
    }
    return 0;
}