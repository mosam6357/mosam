#include <stdio.h>

int main(){
    int a,b,c,s=0;
    scanf("%d %d",&a,&b);
    for (int i=0; i<a; i++){
        scanf("%d",&c);
        s+=c/b;
    }
    printf("%d",s);
}