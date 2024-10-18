#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    int min = a<b?a:b;
    min = min<c?min:c;
    int max = a>b?a:b;
    max = max>c?max:c;
    printf("%d",a+b+c-min-max);
}