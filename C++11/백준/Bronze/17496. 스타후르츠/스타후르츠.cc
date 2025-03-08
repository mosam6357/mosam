#include <iostream>
using namespace std;

int main(void){
    int a,b,c,d,total = 0;
    cin >> a>>b>>c>>d;
    for (int i=b+1;i<a+1;i+=b){
        total+=c*d;
    }
    cout << total;
    return 0;
}