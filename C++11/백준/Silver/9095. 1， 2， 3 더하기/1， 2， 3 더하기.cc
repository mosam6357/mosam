#include <stdio.h>

int main(){
    int a,b;
    scanf("%d",&a);
    for (int i=0; i<a;i++){
        scanf("%d",&b);
        if(b<4){
            int aa[4] = {0,1,2,4};
            printf("%d\n",aa[b]);
        }
        else{
            int aa[b+1] = {0,1,2,4};
            for(int j=4;j<b+1;j++){
                aa[j]=aa[j-1]+aa[j-2]+aa[j-3];
            }
            printf("%d\n",aa[b]);
        }
    }
}