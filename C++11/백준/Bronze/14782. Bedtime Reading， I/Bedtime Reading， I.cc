#include <iostream>
using namespace std;

int main(){
    int a,sum = 0;
    cin >> a;
    for (int i=1;i<a+1;i++){
        if (a%i==0)sum+=i;
    }
    cout << sum;
}