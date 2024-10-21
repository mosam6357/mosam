#include <stdio.h>

int main(){
    int a,b,cost;
    scanf("%d\n%d",&a,&b);
    b+=60;
    if(a>=b){
        cost = (a-b)*3000+b*1500;
    }
    else{
        cost = a*1500;
    }
    printf("%d",cost);
}