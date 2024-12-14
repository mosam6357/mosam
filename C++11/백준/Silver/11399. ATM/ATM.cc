#include <stdio.h>
#include <stdlib.h>

int compare(const void* a, const void* b) {
	int num1 = *(int *)a;
    int num2 = *(int *)b;
    if(num1>num2){
        return 1;
    }
    else if(num1<num2){
        return -1;
    }
    else{
        return 0;
    }
}
int main(){
    int q;
    scanf("%d",&q);
    int aa[q]={};
    for(int i=0; i<q; i++){
        scanf("%d",&aa[i]);
    }
    qsort(aa,q,sizeof(int),compare);
    int t=0;
    int st=0;
    for(int i=0; i<q; i++){
        t+=aa[i];
        st+=t;
    }
    printf("%d",st);
}