#include <iostream>
using namespace std;

int main(){
    char c,c1,c2;
    int a,s=0;
    cin >> c >> a;
    int q[26] = {0,};
    q[(int)c-65]++;
    for (int i=0;i<a;i++){
        cin >> c1 >> c2;
        if(c2==c){
            c=c1;
            q[(int)c-65]=1;
        }
    }
    for (int i=0;i<26;i++){s+=q[i];}
    cout << c << endl << s;
    return 0;
}