#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    if(a%3==1){
        printf("U");
    }
    else if(a%3==2){
        printf("O");
    }
    else{
        printf("S");
    }
}