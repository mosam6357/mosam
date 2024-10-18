#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    int b = a>100?-1:(a==100?0:1);
    printf("%d %d",a*5-400,b);
}