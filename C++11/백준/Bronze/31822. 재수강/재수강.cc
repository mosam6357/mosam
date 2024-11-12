#include <iostream>
using namespace std;

int main(){
    string a,b;
    int q;
    int cnt = 0;
    cin >> a >> q;
    for (int i =0; i<q; i++){
        cin >> b;
        string c = a.substr(0,5);
        string d = b.substr(0,5);
        if(c.compare(d)==0){
            cnt++;
        }
    }
    cout << cnt;
}