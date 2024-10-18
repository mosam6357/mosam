#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    if(a+b+c<100){
        int min = a<b?a:b;
        min = min<c?min:c;
        if(min==a){
            printf("Soongsil");
        }
        else if(min==b){
            printf("Korea");
        }
        else{
            printf("Hanyang");
        }
    }
    else{
        printf("OK");
    }
}