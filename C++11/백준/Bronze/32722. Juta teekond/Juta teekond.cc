#include <stdio.h>

int main(){
    int a,ck=0;
    int aa[6] = {1,3,6,8,2,5};
    for(int i=0; i<3; i++){
        scanf("%d",&a);
        if(a!=aa[i*2] && a!=aa[i*2+1]){
            ck=1;
        }
    }
    printf("%s",(ck==0)?"JAH":"EI");
}