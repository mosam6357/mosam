#include <stdio.h>

int main(){
    int a,b;
    scanf("%d\n%d",&a,&b);
    if(a>2 && b>2){
        printf("%d",a*b-(a-2)*(b-2));
    }
    else{
        printf("%d",a*b);
    }
}