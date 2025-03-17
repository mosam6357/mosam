#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a,n;
    cin >> a;
    while(true){
        string s;
        cin >> s;
        if (s=="="){
            cout << a;
            break;
        }
        else{
            cin >> n;
            if (s=="+"){
                a+=n;
            }
            else if(s=="-"){
                a-=n;
            }
            else if(s=="*"){
                a*=n;
            }
            else{
                a/=n;
            }
        }
    }
    return 0;
}