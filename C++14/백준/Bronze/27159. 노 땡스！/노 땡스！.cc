#include <iostream>
#include <vector>
using namespace std;

int main(void){
    int a,n,total=0;
    vector<int> aa;
    cin >> a;
    for (int i=0;i<a;i++){
        cin >> n;
        aa.push_back(n);
        if (i==0 || aa[i]!=aa[i-1]+1){
            total+=aa[i];
        }
    }
    cout << total;
}