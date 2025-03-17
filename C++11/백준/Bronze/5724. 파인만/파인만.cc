#include <iostream>
using namespace std;

int main(void){
    while(true){
        int n,total = 0;
        cin >> n;
        if(n==0){
            break;
        }
        for (int i=1;i<=n;i++){
            total+=i*i;
        }
        cout << total << '\n';
    }
    return 0;
}