#include <stdio.h>

int main(){
    int a,b,c,d,time;
    scanf("%d %d %d %d",&a,&b,&c,&d);
    time = (c-a)*60+(d-b);
    time = time<0?time+1440:time;
    printf("%d %d",time,time/30);
}