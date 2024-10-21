#include <stdio.h>

int main(){
    int a[4];
    int tile =4;
    for (int i =0; i<4; i++){
        scanf("%d",&a[i]);
    }
    tile+=a[0]>a[2]?a[0]*2:a[2]*2;
    tile+=(a[1]+a[3])*2;
    printf("%d",tile);
}