#include <stdio.h>
#include <string.h>

int main(){
    int a,b,c;
    scanf("%d/%d/%d",&a,&b,&c);
    if(a<=12 && b<=12){
        printf("either");
    }
    else if(a>12){
        printf("EU");
    }
    else{
        printf("US");
    }
}