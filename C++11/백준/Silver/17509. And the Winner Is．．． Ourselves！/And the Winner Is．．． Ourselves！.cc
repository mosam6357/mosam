#include <iostream>
using namespace std;

int compare(const void* a, const void* b){
    return *(int*)a-*(int*)b;
}
int main(){
    int p=0,time=0,x;
    int aa[11];
    for (int i=0;i<11;i++){
        cin >> aa[i] >> x;
        p+=20*x;
    }
    qsort(aa,11,sizeof(int),compare);
    for (int i=0;i<11;i++){
        time+=aa[i];
        p+=time;
    }
    cout << p;
}