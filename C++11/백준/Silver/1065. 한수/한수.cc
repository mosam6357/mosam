#include <iostream>
#include <string>
using namespace std;

int main(){
    int a,cnt=0;
    cin >> a;
    for (int i=1;i<=a;i++){
        if(i<=99){
            cnt++;
        }
        else{
            string s = to_string(i);
            int ck = 0;
            int x = 0;
            for (int j=0;j<s.length()-1;j++){
                int t = s[j+1]-s[j];
                if(j==0){
                    x = t;
                }
                else{
                    if(x!=t){
                        ck = 1;
                        break;
                    }
                }
            }
            if(ck==0)cnt++;
        }
    }
    cout << cnt;
}