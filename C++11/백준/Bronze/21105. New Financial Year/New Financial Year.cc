#include <iostream>
using namespace std;

int main(void){
    int a;
    double p,c;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> p >> c;
        cout << p*100/(c+100)<<endl;
    }
    return 0;
}