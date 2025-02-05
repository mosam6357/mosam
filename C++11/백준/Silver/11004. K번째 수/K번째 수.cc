#include <iostream>
#include <algorithm>
using namespace std;

int main(){
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    int a,b;
    cin >> a>> b;
    int aa[a];
    for (int i=0;i<a;i++){
        cin >> aa[i];
    }
    sort(aa,aa+a);
    cout << aa[b-1];
}