#include <iostream>
using namespace std;

int main(){
    int a,b;
    int cnt=0;
    while(true){
        cin >> a;
        if(a==0)break;
        for (int i=0; i<a; i++){
            cin >> b;
        }
        printf("Case %d: Sorting... done!\n",cnt+1);
        cnt++;
    }
}