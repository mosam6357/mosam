#include <iostream>
using namespace std;
int main(){
    string a,s;
    cin >> a >> s;
    for (int i=0; i<s.length(); i++){
        if(s[i]=='I'){
            cout << 'i';
        }
        else{
            cout << 'L';
        }
    }
}