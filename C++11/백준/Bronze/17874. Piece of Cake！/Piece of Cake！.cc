#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    b=b>a-b?b:a-b;
    c=c>a-c?c:a-c;
    printf("%d",b*c*4);
}