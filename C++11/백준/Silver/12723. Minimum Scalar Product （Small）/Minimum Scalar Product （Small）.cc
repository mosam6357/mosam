#include <stdio.h>
#include <stdlib.h>

int compare(const void* q,const void* w){
    int* a = (int*)q;
    int* b = (int*)w;
    return *a-*b;
}
int compare2(const void* q,const void* w){
    int* a = (int*)q;
    int* b = (int*)w;
    return *b-*a;
}
int main(){
    int a,b;
    scanf("%d",&a);
    for (int i=0; i<a; i++){
        scanf("%d",&b);
        int aa[b];
        int bb[b];
        int ans = 0;
        for (int j=0;j<b;j++){
            scanf("%d",aa+j);
        }
        for (int j=0;j<b;j++){
            scanf("%d",bb+j);
        }
        qsort(aa,b,sizeof(int),compare);
        qsort(bb,b,sizeof(int),compare2);
        for(int j=0;j<b;j++){
            ans+=aa[j]*bb[j];
        }
        printf("Case #%d: %d\n",i+1,ans);
    }
}