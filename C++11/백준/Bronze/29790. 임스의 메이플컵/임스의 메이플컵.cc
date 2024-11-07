#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    if(a>=1000 && (b>=8000 || c>=260)){
        printf("Very Good");
    }
    else{
        printf(a>=1000?"Good":"Bad");
    }
}