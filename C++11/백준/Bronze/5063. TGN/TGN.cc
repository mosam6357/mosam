#include <iostream>
using namespace std;

int main(void){
    int t;
    cin >> t;
    for (int i=0;i<t;i++){
        int a,b,c;
        cin >> a >> b >> c;
        if (a<b-c){
            cout << "advertise" << endl;
        }
        else if (a==b-c){
            cout << "does not matter" << endl;
        }
        else{
            cout << "do not advertise" << endl;
        }
    }
}