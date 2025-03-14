#include <string>
#include <iostream>
using namespace std;

int main(void){
    string s1,s2;
    cin >> s1 >> s2;
    if (s1.size()<s2.size()){
        cout << "no";
    }
    else{
        cout << "go";
    }
    return 0;
}