#include <iostream>
#include <cstdlib>
using namespace std;

int compare(const void* a,const void* b){
    return *(int*)a-*(int*)b;
}
int main(void){
    int a;
    cin >> a;
    int aa[a];
    for (int i=0;i<a;i++){
        cin >> aa[i];
    }
    qsort(aa,a,sizeof(int),compare);
    cout << aa[0]+aa[1];
    return 0;
}