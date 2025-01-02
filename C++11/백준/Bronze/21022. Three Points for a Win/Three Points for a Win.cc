#include <iostream>
using namespace std;

int main(){
    int a,s=0;
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
        if(aa[i]>bb[i]){
            s+=3;
        }
        else if(aa[i]==bb[i]){
            s++;
        }
    }
    cout << s; 
}