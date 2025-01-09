#include <iostream>
using namespace std;

int main(){
    int a,i=1;
    cin >> a;
    int aa[] = {0,0};
    while (a>0){
        int k = i%2;
        if (a%2==0){
            aa[k]+=a/2;
            a-=a/2;
        }
        else{
            aa[k]+=a/2+1;
            a-=a/2+1;
        }
        i++;
    }
    cout << aa[0] << " " << aa[1];
}