#include <iostream>
using namespace std;

int main(void){
    int a,b,c,d;
    int aa[4] = {0,};
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> b >> c >> d;
        if (b==1){
            aa[3]++;
        }
        else if(c==1 || c==2){
            aa[0]++;
        }
        else if(c==3){
            aa[1]++;
        }
        else{
            aa[2]++;
        }
    }
    for (int i=0;i<4;i++){
        cout << aa[i] << endl;
    }
    return 0;
}