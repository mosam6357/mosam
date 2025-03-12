#include <iostream>
using namespace std;

int main(void){
    int t,n;
    cin >> t;
    for (int i=0;i<t;i++){
        int max = 0;
        int total = 0;
        for (int j=0;j<3;j++){
            cin >> n;
            max = max>n?max:n;
            total += n*n;
        }
        if(total-max*max==max*max){
            cout << "Scenario #" << i+1 <<":"<< "\nyes\n\n";
        }
        else{
            cout << "Scenario #" << i+1 <<":"<< "\nno\n\n";
        }
    }
    return 0;
}