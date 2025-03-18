#include <iostream>
using namespace std;

int main(void){
    int a;
    cin >> a;
    for (int i=0;i<5;i++){
        for (int j=0;j<a;j++){
            if (i==0){
                for (int k=0;k<a*5;k++){
                    cout << "@";
                }
            }
            else{
                for (int k=0;k<a;k++){
                    cout << "@";
                }
            }
            cout << '\n';
        }
    }
    return 0;
}