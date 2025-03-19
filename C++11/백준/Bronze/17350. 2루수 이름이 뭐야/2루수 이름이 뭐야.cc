#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    cin >> a;
    string s;
    for (int i=0;i<a;i++){
        cin >> s;
        if (s=="anj"){
            cout << "뭐야;";
            break;
        }
        if (i==a-1){
            cout << "뭐야?";
        }
    }
    return 0;
}