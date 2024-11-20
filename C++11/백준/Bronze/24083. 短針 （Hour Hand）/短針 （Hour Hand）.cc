#include <stdio.h>

int main(){
    int a,b;
    scanf("%d %d",&a,&b);
    a+=b;
    if(a>12){
        if(a%12==0){
            printf("12");
        }
        else{
            printf("%d",a%12);
        }
    }
    else{
        printf("%d",a);
    }
}