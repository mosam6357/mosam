#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d",&a);
    for (int i=0;i<a; i++){
        scanf("%d %d",&b,&c);
        int s = c*2-b;
        printf("%d %d\n",s,c-s);
    }
}