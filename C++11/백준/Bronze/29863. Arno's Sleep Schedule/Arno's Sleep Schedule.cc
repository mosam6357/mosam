#include <stdio.h>

int main(){
    int a,b;
    scanf("%d\n%d",&a,&b);
    printf("%d",(b-a>0)?b-a:b-a+24);
}