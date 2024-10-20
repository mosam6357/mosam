#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    int max = a>b?a:b;
    max = max>c?max:c;
    int sum = max*3-(a+b+c);
    printf("%d",sum);
}