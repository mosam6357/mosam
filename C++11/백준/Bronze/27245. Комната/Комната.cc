#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d\n%d\n%d",&a,&b,&c);
    int max=a>b?a:b;
    int min=a<b?a:b;
    if(max>min*2 || c*2>min){
        printf("bad");
    }
    else{
        printf("good");
    }
}