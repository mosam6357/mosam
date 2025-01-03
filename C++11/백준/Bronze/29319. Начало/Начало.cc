#include <iostream>
using namespace std;

int main(){
    int a,b,sum=0,max=0;
    cin>>a;
    for (int i=0;i<a;i++){
        cin >> b;
        max = max>b?max:b;
        sum += b;
    }
    printf("%d",sum-max);
}