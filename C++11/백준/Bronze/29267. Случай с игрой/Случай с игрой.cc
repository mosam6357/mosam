#include <iostream>
using namespace std;

int main(){
    int a,b,save=0,cnt=0;
    string s;
    cin >> a>> b;
    for (int i=0; i<a; i++){
        cin >>s;
        if(s[1]=='a'){
            save = cnt;
            cout << cnt << endl;
        }
        if(s[1]=='o'){
            cnt = save;
            cout << cnt << endl;
        }
        if(s[1]=='h'){
            cout << --cnt << endl;
        }
        if(s[1]=='m'){
            cnt += b;
            cout << cnt <<endl;
        }
    }
}