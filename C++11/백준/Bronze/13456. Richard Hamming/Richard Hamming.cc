#include <iostream>
using namespace std;

int main(){
    int q;
    cin >> q;
    for (int j=0;j<q;j++){
    int a,s=0,cnt=0;
    cin >> a;
    int aa[a];
    int bb[a];
    for (int i=0;i<a;i++){
        cin >> aa[i];
    }
    for (int i=0;i<a;i++){
        cin >> bb[i];
    }
    for (int i=0;i<a;i++){
        if(aa[i]!=bb[i]){
            cnt++;
        }
    }
    cout << cnt << endl;
}
}