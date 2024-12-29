#include <stdio.h>

int main(){
    int a,t=10,l=1;
    scanf("%d",&a);
    while(a>t){
        if(a%t<=4*l){
            a-=a%t;
        }
        else{
            a=(a/t+1)*t;
        }
        t*=10;
        l*=10;
    }
    printf("%d",a);
}