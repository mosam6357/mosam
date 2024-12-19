#include <stdio.h>

int main(){
    int a,b,cnt=0;
    scanf("%d",&a);
    int aa[a];
    for (int i=0; i<a; i++){
        scanf("%d",&aa[i]);
    }
    for (int i=0; i<a; i++){
        scanf("%d",&b);
        if(b>=aa[i])cnt++;
    }
    printf("%d",cnt);
}