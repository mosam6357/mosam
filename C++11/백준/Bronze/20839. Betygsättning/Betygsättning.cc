#include <stdio.h>

int main(){
    int a[6];
    for(int i=0;i<6;i++){
        scanf("%d",&a[i]);
    }
    if(a[0]==a[3] && a[1]==a[4] && a[2]==a[5]){
        printf("A");
    }
    else if(a[1]==a[4] && a[2]==a[5]){
        if(a[3]>=(a[0]+1)/2){
            printf("B");
        }
        else{
            printf("C");
        }
    }
    else{
        if(a[4]>=(a[1]+1)/2){
            printf("D");
        }
        else{
            printf("E");
        }
    }
}