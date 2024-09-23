#include <stdio.h>

int main(){
    long a; long ans=1L;
    scanf("%ld", &a);
    for(int i =0; i<a; ++i){
        ans*=i+1;
    }
    printf("%ld",ans);
}