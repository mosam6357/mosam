#include <iostream>
#include <string>
using namespace std;

int main(void){
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    int cnt = 0;
    string s;
    while(getline(cin,s)){
        cnt++;
    }
    cout << cnt;
    return 0;
}