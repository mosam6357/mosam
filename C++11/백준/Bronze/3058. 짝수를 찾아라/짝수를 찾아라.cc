#include <iostream>
using namespace std;

int main(void){
    int n,t;
    cin >> t;
    for (int i=0;i<t;i++){
        int min = 100;
        int sum = 0;
        for (int j=0;j<7;j++){
            cin >> n;
            if (n%2==0){
                min=min<n?min:n;
                sum+=n;
            }
        }
        cout << sum << " " << min <<endl;
    }
    return 0;
}