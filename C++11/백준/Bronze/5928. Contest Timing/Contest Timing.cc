#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    int time = (a-11)*1440+(b-11)*60+(c-11);
    printf("%d",(time<0)?-1:time);
}