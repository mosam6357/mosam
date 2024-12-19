#include <stdio.h>

int main(){
    int a,b,c,d;
    scanf("%d %d",&a,&b);
    c = a+b; d=a-b;
    printf("%d\n",c>d?c:d);
    printf("%d",c<d?c:d);
}