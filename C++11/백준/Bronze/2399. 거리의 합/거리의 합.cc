#include <iostream>
using namespace std;

int cp(const void* a, const void* b){
    return *(long long *)a-*(long long *)b;
}
int main(){
    int a;
    cin >> a;
    long long aa[a];
    for (int i=0;i<a;i++){
        cin >> aa[i];
    }
    long long ans = 0;
    qsort(aa,a,sizeof(long long),cp);
    for (int i=0;i<a-1;i++){
        for (int j=i+1;j<a;j++){
            ans += (aa[j]-aa[i])*2;
        }
    }
    cout << ans;
}