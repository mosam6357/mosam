#include <stdio.h>

int main(){
    int a,b;
    scanf("%d %d",&a,&b);
    a*=7; b*=13;
    printf("%s",(a==b)?"lika":(a>b)?"Axel":"Petra");
}