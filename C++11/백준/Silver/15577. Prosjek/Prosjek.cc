#include <stdio.h>
#include <stdlib.h>

int compare(const void *a,const void*b){
    return (*((double*)a)-*((double*)b));
}
int main(){
    int a;
    scanf("%d",&a);
    double aa[a];
    for (int i=0;i<a;i++){
        scanf("%lf",&aa[i]);
    }
    qsort(aa,a,sizeof(double),compare);
    for (int i=0;i<a-1;i++){
        aa[i+1] = (aa[i]+aa[i+1])/2;
    }
    printf("%lf",aa[a-1]);
}