#include <iostream>
using namespace std;
int main(){
    string a;
    int cnt = 0;
    cin >> a;
    for (int i=0; i<a.length(); i++){
        if(a[i]=='a' || a[i]=='e' || a[i]=='i' || a[i]=='o' || a[i]=='u'){
            cnt++;
        }
    }
    cout << cnt;
}