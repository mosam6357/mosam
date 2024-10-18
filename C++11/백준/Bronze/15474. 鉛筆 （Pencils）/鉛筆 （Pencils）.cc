#include <stdio.h>

int main(){
    int a,b,c,d,e;
    scanf("%d %d %d %d %d",&a,&b,&c,&d,&e);
    int c1 = a%b==0?(a/b)*c:(a/b+1)*c;
    int c2 = a%d==0?(a/d)*e:(a/d+1)*e;
    printf("%d",c1<c2?c1:c2);
}