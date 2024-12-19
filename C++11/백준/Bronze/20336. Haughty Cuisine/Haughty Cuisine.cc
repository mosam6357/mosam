#include <stdio.h>

int main(){
    int a,b;
    char c[100];
    scanf("%d\n%d",&a,&b);
    printf("%d\n",b);
    for (int i=0; i<b; i++){
        scanf("%s",c);
        printf("%s\n",c);
    }
}