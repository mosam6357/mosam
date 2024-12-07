#include <stdio.h>

int main(){
    int a,b;
    char c;
    scanf("%d",&a);
    for (int i=0; i<a; i++){
        scanf("%d %c",&b,&c);
        for (int j=0; j<b; j++){
            printf("%c",c);
        }
        printf("\n");
    }
}