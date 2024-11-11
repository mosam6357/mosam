#include <stdio.h>

int main(){
    int a,b,c,d,e;
    scanf("%d %d %d %d %d",&a,&b,&c,&d,&e);
    if(a+b+c+d>=e*4){
        printf("0");
    }
    else{
        printf("%d",e*4-(a+b+c+d));
    }
}