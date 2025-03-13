#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    string s;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> s;
        if(s[s.size()/2-1]==s[s.size()/2]){
            cout << "Do-it"<< endl;
        }
        else{
            cout << "Do-it-Not" << endl;
        }
    }
}