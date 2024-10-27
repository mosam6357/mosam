#include <stdio.h>

int main(){
    int a,b,c,d;
    scanf("%d",&a);
    for(int i =0; i<a; i++){
        scanf("%d",&b);
        for (int j =0; j<b; j++){
            scanf("%d %d",&c,&d);
            printf("%d %d\n",c+d,c*d);
        }
    }
}