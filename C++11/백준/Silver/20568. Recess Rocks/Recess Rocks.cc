#include <stdio.h>
#include <stdlib.h>

int compare(const void* q,const void* w){
    int* a = (int*)q;
    int* b = (int*)w;
    return *a-*b;
}
int main(){
    int a,cnt=0;
    scanf("%d",&a);
    int aa[a];
    for (int i=0;i<a;i++){
        scanf("%d",aa+i);
    }
    qsort(aa,a,sizeof(int),compare);
    for (int i=1; i<a;i++){
        if(aa[i]==aa[i-1]){
            cnt++;
        }
    }
    printf("%d",cnt);
}