#include <stdio.h>

int main(){
    int a,b;
    scanf("%d",&a);
    for (int i=0; i<a; i++){
        scanf("%d",&b);
        int c = b%100;
        if ((b+1)%c==0){
            printf("Good\n");
        }
        else{
            printf("Bye\n");
        }
    }
}