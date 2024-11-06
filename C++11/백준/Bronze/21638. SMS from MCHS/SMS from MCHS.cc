#include <stdio.h>

int main(){
    int a[2];
    int b[2];
    scanf("%d %d",&a[0],&a[1]);
    scanf("%d %d",&b[0],&b[1]);
    if(b[0]<0 && b[1]>=10){
        printf("A storm warning for tomorrow! Be careful and stay home if possible!");
    }
    else if(b[0]<a[0]){
        printf("MCHS warns! Low temperature is expected tomorrow.");
    }
    else if(b[1]>a[1]){
        printf("MCHS warns! Strong wind is expected tomorrow.");
    }
    else{
        printf("No message");
    }
}