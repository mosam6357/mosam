#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    cin >> a;
    for (int i=0;i<a;i++){
        string s;
        cin >> s;
        if(((int)s[s.length()-1])%2==0){
            cout << "even" << endl;
        }
        else{
            cout << "odd" << endl;
        }
    }
    return 0;
}