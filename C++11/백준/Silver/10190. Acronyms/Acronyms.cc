#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int main(){
    int a,b;
    string s1,s2="",s3;
    string ss;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> s1 >> b;
        cout << s1<<endl;
        cin.ignore();
        for (int j=0;j<b;j++){
            string s2 = "";
            getline(cin,ss);
            stringstream stream (ss);
            while(getline(stream,s3,' ')){
                s2+=s3[0];
            }
            if(s1==s2){
                cout << ss << endl;
            }
        }
    }
    return 0;
}