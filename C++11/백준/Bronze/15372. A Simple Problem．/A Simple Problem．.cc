#include <stdio.h>

int main(){
    int a;
    long b;
    scanf("%d",&a);
    for (int i=0; i<a; i++){
        scanf("%ld",&b);
        printf("%ld\n",b*b);
    }
}