#include <iostream>
using namespace std;

int main(){
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    int a,b,n;
    cin >> a >> b;
    int add[a];
    int total = 0;
    for (int i=0;i<a;i++){
        cin >> n;
        total += n;
        add[i] = total;
    }
    for (int i=0;i<b;i++){
        int s,e;
        cin >> s >> e;
        if (s<2){
            cout << add[e-1] <<"\n";
        }
        else{
            cout << add[e-1]-add[s-2] <<"\n";
        }
    }
}