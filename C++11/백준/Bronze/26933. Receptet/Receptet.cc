#include <stdio.h>

int main(){
    int n,a,b,c,s=0;
    scanf("%d",&n);
    for (int i=0; i<n; i++){
        scanf("%d %d %d",&a,&b,&c);
        s+=(a<b)?(b-a)*c:0;
    }
    printf("%d",s);
}