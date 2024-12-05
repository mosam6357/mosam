#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    printf("%s",(a%2024==0 && a<100000)?"Yes":"No");
}