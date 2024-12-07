#include <stdio.h>

int main(){
    int a,b,c=0;
    scanf("%d",&a);
    for(int i=0; i<3; i++){
        scanf("%d",&b);
        c+=b;
    }
    if(c<a && a>240){
        printf("flight");
    }
    else{
        printf("high speed rail");
    }
}