#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

int main(void){
    int a,n;
    cin >> a;
    vector<int> aa,bb;
    for (int i=0;i<a;i++){
        cin >> n;
        aa.push_back(n);
    }
    for (int i=0;i<a;i++){
        cin >> n;
        bb.push_back(n);
    }
    int total = 0;
    for (int i=0;i<a;i++){
        total += abs(aa[i]-bb[i]); 
    }
    cout << total/2;
    return 0;
}