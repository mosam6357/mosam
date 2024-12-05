#include <stdio.h>

int main(){
    int a,s=0;
    while(true){
        scanf("%d",&a);
        if(a==-1)break;
        s+=a;
    }
    printf("%d",s);
}