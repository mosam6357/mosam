#include <iostream>
using namespace std;

int main(){
    int a;
    cin >> a;
    int aa[a] = {0,};
    for (int i=0;i<a;i++){
        cin >> aa[i];
        int cnt = 0;
        for (int j=0;j<i;j++){
            if(aa[i]>aa[j])cnt++;
        }
        cout << cnt << endl;
    }
    return 0;
}