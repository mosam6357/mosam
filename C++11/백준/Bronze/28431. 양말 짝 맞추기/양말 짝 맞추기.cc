#include <stdio.h>

int main(){
    int aa[10] = {0,};
    int i;
    for(i =0; i<5; i++){
        int a;
        scanf("%d",&a);
        if(aa[a]==0){
            aa[a]++;
        }
        else{
            aa[a]--;
        }
    }
    for(int i =0; i<10; i++){
        if(aa[i]==1){
            printf("%d",i);
            break;
        }
    }
}