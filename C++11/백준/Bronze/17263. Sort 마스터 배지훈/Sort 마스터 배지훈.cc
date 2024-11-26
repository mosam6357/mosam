#include <stdio.h>

int main(){
    int a;
    int max=0;
    scanf("%d",&a);
    for(int i=0; i<a; i++){
        int b;
        scanf("%d",&b);
        max = max>b?max:b;
    }
    printf("%d",max);
}