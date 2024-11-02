#include <iostream>
using namespace std;

int main(){
    int a;
    cin >> a;
    for (int i=0; i<a; i++){
        string b;
        cin >> b;
        int walk = 0;
        for (int j=0; j<b.length(); j++){
            if(b[j]=='U'){
                walk++;
            }
            else{
                break;
            }
        }
        cout << walk << endl;
    }
}