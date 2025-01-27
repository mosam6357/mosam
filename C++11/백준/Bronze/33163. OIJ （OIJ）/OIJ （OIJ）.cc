#include <iostream>
#include <string>
using namespace std;

int main(){
    int a;
    cin >> a;
    string c;
    cin >> c;
    string s="";
    for (int i=0;i<a;i++){
        if(c[i]=='J'){
            s+='O';
        }
        else if(c[i]=='O'){
            s+='I';
        }
        else{
            s+='J';
        }
    }
    cout << s;
}