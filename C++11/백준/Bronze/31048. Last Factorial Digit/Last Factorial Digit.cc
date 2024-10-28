#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    for(int i=0; i<a; i++){
        int b;
        int c[5] = {1,1,2,6,4};
        scanf("%d",&b);
        if(b>4){
            printf("0\n");
        }
        else{
            printf("%d\n",c[b]);
        }
    }
}