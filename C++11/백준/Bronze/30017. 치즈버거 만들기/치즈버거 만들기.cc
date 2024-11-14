#include <stdio.h>

int main(){
    int a,b;
    scanf("%d %d",&a,&b);
    printf("%d",a<=b?2*a-1:2*b+1);
}