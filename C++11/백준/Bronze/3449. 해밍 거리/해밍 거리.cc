#include <iostream>
#include <string>
using namespace std;

int main(void){
    int a;
    cin >> a;
    for (int i=0;i<a;i++){
        string s1,s2;
        int cnt = 0;
        cin >> s1 >> s2;
        for (int j=0;j<s1.size();j++){
            if (s1[j]!=s2[j]){
                cnt++;
            }
        }
        cout << "Hamming distance is " <<cnt <<"." << '\n';
    }
    return 0;
}