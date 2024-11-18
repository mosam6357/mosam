#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d\n%d\n%d",&a,&b,&c);
    if(a+b*2+c*3>=10){
        printf("happy");
    }
    else{
        printf("sad");
    }
}