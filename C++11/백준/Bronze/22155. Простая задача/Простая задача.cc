#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    for(int i=0;i<a;i++){
        int b,c;
        scanf("%d %d",&b,&c);
        if((b<=1 && c<=2) || (b<=2 && c<=1)){
            printf("Yes\n");
        }
        else{
            printf("No\n");
        }
    }
}