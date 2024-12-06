#include <stdio.h>

int main(){
    int q,a,b,c;
    scanf("%d",&q);
    for(int i=0; i<q;i++){
        scanf("%d %d %d",&a,&b,&c);
        printf("%d\n",a*(c-1)+b);
    }
}