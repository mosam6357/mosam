#include <stdio.h>

int main(){
    int a,sum=-1;
    for (int i=0; i<4; i++){
        scanf("%d",&a);
        sum+=a;
    }
    printf("%d",(sum%4==0)?4:sum%4);
}