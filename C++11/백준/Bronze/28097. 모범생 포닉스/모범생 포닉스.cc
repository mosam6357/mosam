#include <stdio.h>

int main(){
    int a,b,s;
    scanf("%d",&a);
    s = 8*(a-1);
    for (int i =0; i<a; i++){
        scanf("%d",&b);
        s+=b;
    }
    printf("%d %d",s/24,s%24);
}