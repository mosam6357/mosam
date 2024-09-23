#include <stdio.h>

int main(){
    int a; long ans=1;
    scanf("%d", &a);
    for(int i =0; i<a; i++){
        ans*=i+1;
    }
    printf("%ld",ans);
}