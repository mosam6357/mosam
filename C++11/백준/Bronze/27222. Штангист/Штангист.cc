#include <iostream>
using namespace std;

int main(){
    int a,ans = 0;
    cin >> a;
    int aa[a];
    for (int i=0;i<a;i++){
        cin >> aa[i];
    }
    for (int i=0;i<a;i++){
        int b,c;
        cin >> b>>c;
        if (aa[i]==1 && b<c){
            ans+=c-b;
        }
    }
    cout << ans;
    return 0;
}