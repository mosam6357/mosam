#include <iostream>
using namespace std;

int compare(const void* a, const void* b){
    return (*(int*)a-*(int*)b);
}
int main(){
    int a;
    cin >> a;
    int aa[a];
    for (int i=0;i<a;i++){
        cin >> aa[i];
    }
    qsort(aa,a,sizeof(int),compare);
    int m = 0;
    for (int i=0;i<a;i++){
        aa[i] *= a-i;
        m = m>aa[i]?m:aa[i];
    }
    cout << m;
}