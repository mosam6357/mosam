#include <stdio.h>

int main(){
    int a,b,c,d;
    scanf("%d",&a);
    for(int i=0; i<a;i++){
        scanf("%d %d %d",&b,&c,&d);
        printf("%d\n",(c>=d)?0:(d-c)*(b*2-1));
    }
}