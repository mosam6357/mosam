#include <stdio.h>

int main(){
    int a[5] = {0,0,0,0,0};
    scanf("%d %d %d %d %d",&a[0],&a[1],&a[2],&a[3],&a[4]);
    int max = 30000;
    int cnt = 0;
    for (int i=0; i<5; i++){
        max = max>a[i]?max:a[i];
    }
    for (int i =0; i<5; i++){
        if(a[i]!=max && max-a[i]<=1000){
            cnt++;
        }
    }
    printf("%d", cnt);
}