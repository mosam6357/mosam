#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d-%d-%d",&a,&b,&c);
    if(b<9 ||(b==9 && c<=16)){
        printf("GOOD");
    }
    else{
        printf("TOO LATE");
    }
}