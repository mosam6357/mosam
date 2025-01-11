#include <iostream>
#include <string.h>
#include <stdlib.h>
using namespace std;

int main(){
    char a[20],b[20],c[20],d[20];
    cin >> a>>b>>c>>d;
    strcat(a,b);
    strcat(c,d);
    long long ans = atoll(a)+atoll(c);
    cout << ans;
}