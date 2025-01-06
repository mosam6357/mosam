#include <iostream>
using namespace std;

int main(){
    int q;
    cin >> q;
    for (int i=0;i<q;i++){
        int n,a,b;
        cin >> n >> a >> b;
        int aa[n];
        for (int j=0;j<n;j++){
            cin >> aa[j];
        }
        if(aa[0]==a && aa[n-1]==b){
            cout << "BOTH" << endl;
        }
        else if(aa[0]==a && aa[n-1]!=b){
            cout << "EASY" << endl;
        }
        else if(aa[0]!=a && aa[n-1]==b){
            cout << "HARD" << endl;
        }
        else{
            cout << "OKAY" << endl;
        }
    }
}