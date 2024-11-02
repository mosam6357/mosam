#include <iostream>
using namespace std;

int main(){
    int a[4];
    int sum = 0;
    int min = 500;
    for (int i =0; i<4; i++){
        cin >> a[i];
        sum+=a[i];
        min=min<a[i]?min:a[i];
    }
    cout<<sum-min+1;
}