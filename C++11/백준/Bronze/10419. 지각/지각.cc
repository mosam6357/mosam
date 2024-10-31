#include <stdio.h>

int main(){
    int a,b;
    scanf("%d",&a);
    for(int i=0; i<a; i++){
        int j = 1;
        scanf("%d",&b);
        while(j*j+j<=b){
            j++;
        }
        printf("%d\n",j-1);
    }
}