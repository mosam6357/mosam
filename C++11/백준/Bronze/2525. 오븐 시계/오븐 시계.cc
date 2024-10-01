#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d\n%d",&a,&b,&c);
    int d=b+c;
    if(d>59){
        b=d%60;
        a=a+d/60;
        if(a>23){
            a=a%24;
        }
    }
    else{
        b=d;
    }
    printf("%d %d",a,b);
}