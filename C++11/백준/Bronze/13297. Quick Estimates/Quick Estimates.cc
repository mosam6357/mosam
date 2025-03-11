#include <iostream>
#include <string>
using namespace std;

int main(){
    int a;
    string s;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> s;
        cout << s.size() << endl;
    }
    return 0;
}