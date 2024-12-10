#include <stdio.h>

int main(){
    int a=0,b;
    for (int i=0; i<4; i++){
        scanf("%d",&b);
        a+=b;
    }
    printf("%d %d",a/60,a%60);
}