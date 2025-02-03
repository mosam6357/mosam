#include <iostream>
using namespace std;

int main(){
    int a;
    cin >> a;
    int aa[a];
    int bb[a];
    for (int i=0;i<a;i++){
        cin >> aa[i] >> bb[i];
    }
    for (int i=0;i<a;i++){
        int s = 1;
        for (int j=0;j<a;j++){
            if(aa[i]<aa[j] && bb[i]<bb[j])s++;
        }
        cout << s << " ";
    }
    return 0;
}