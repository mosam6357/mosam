#include <stdio.h>

int main(){
    int a,b;
    int cnt = 0;
    scanf("%d",&a);
    for (int i=0; i<5; i++){
        scanf("%d",&b);
        if(a==b){
            cnt++;
        }
    }
    printf("%d",cnt);
}