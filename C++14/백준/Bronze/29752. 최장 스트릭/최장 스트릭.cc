#include <iostream>
using namespace std;

int main(void){
    int a,n,c=0,cm=0;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> n;
        if (n==0){
            cm = cm>c?cm:c;
            c=0;
        }
        else{
            c++;
        }
    }
    cm = cm>c?cm:c;
    cout << cm;
    return 0;
}