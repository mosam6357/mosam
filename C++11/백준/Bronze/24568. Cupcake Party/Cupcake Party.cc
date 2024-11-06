#include <stdio.h>

int main(){
    int a,b;
    scanf("%d\n%d",&a,&b);
    int cake = a*8+b*3;
    printf("%d",cake>28?cake-28:0);
}