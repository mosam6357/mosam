#include <stdio.h>

int main(){
    long long int a;
    scanf("%ld",&a);
    printf("%s",(a%7==0 || a%7==2)?"CY":"SK");
}