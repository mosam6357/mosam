#include <iostream>
#include <string>
#include <stdlib.h>
using namespace std;

int compare(const void*q, const void*w){
    return *((int*)q)-*((int*)w);
}
int main(void){
    int a,b,c,max=0;
    cin >> a;
    for (int i=0;i<a;i++){
        int score = 0;
        cin >> b >> c;
        score+=b>c?b:c;
        int aa[5];
        for (int j=0;j<5;j++){
            cin >> aa[j];
        }
        qsort(aa,5,sizeof(int),compare);
        score+=aa[3]+aa[4];
        max = max>score?max:score;
    }
    cout << max;
    return 0;
}