#include <stdio.h>
#include <stdlib.h>

int compare(const void* a,const void* b){
    return *((int*)a)-*((int*)b);
}
int main(){
    int a;
    scanf("%d",&a);
    int aa[a];
    int bb[a];
    for (int i=0;i<a;i++){
        scanf("%d",aa+i);
    }
    for (int i=0;i<a;i++){
        scanf("%d",bb+i);
    }
    qsort(aa,a,sizeof(int),compare);
    qsort(bb,a,sizeof(int),compare);
    int sum = 0;
    for (int i=0;i<a;i++){
        sum+=abs(aa[i]-bb[i]);
    }
    printf("%d",sum);
}