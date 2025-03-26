#include <iostream>
#include <string>
using namespace std;

int main(void){
    double a;
    string s;
    cin >> a >> s;
    double n = s.length()-7.5*a;
    if (n==0){
        cout << "bigdata? security!";
    }
    else if(n>0){
        cout << "security!";
    }
    else{
        cout << "bigdata?";
    }
}