#include <iostream>
using namespace std;

int main(){
    int a,b,c,d,maxsum=0,num=0;
    for (int i=0;i<5;i++){
        cin >> a>>b>>c>>d;
        int sum = a+b+c+d;
        if(sum>maxsum){
            maxsum=sum;
            num=i+1;
        }
    }
    cout << num << " " << maxsum;
}