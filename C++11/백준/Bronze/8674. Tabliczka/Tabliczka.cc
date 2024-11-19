#include <stdio.h>

int main(){
    long a,b;
    scanf("%ld %ld",&a,&b);
    if(a*b%2==0){
        printf("0");
    }
    else{
        printf("%ld",(a<b)?a:b);
    }
}