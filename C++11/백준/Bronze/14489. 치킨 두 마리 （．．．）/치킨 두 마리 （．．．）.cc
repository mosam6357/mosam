#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d\n%d",&a,&b,&c);
    printf("%d",(a+b-c*2<0)?a+b:a+b-c*2);
}