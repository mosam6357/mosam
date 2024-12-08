#include <stdio.h>

int main(){
    int a,b,c;
    int aa[6];
    scanf("%d",&a);
    for(int i=0; i<6; i++){
        scanf("%d",&aa[i]);
    }
    scanf("%d %d",&b,&c);
    int sumt = 0; int sump = a/c; int p = a%c;
    for(int i=0; i<6; i++){
        sumt+=aa[i]/b;
        if(aa[i]%b!=0){
            sumt++;
        }
    }
    printf("%d\n%d %d",sumt,sump,p);
}