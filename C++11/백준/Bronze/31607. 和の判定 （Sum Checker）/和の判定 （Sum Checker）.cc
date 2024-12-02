#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d\n%d\n%d",&a,&b,&c);
    printf("%d",(a+b==c || b+c==a || a+c==b)?1:0);
}