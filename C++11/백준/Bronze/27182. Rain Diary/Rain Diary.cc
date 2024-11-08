#include <stdio.h>

int main(){
    int a,b;
    scanf("%d %d",&a,&b);
    if(a-7<=0){
        printf("%d",b+7);
    }
    else{
        printf("%d",a-7);
    }
}