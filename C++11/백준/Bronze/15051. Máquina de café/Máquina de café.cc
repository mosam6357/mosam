#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d\n%d\n%d",&a,&b,&c);
    int aa[3] = {(b+c*2)*2,(a+c)*2,(a*2+b)*2};
    int min = aa[0]<aa[1]?aa[0]:aa[1];
    min = min<aa[2]?min:aa[2];
    printf("%d",min);
}