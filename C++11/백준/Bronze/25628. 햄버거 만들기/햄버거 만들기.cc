#include <stdio.h>

int main(){
    int a,b;
    scanf("%d\n%d",&a,&b);
    a/=2;
    printf("%d",a<b?a:b);
    return 0;
}