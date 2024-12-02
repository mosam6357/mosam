#include <stdio.h>

int main(){
    int a,b,max;
    scanf("%d",&a);
    for (int i=0; i<a; i++){
        max = 0;
        for (int j =0; j<5; j++){
            scanf("%d",&b);
            max = max>b?max:b;
        }
        printf("Case #%d: %d\n",i+1,max);
    }
}