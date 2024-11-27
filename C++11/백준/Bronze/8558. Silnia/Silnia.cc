#include <stdio.h>

int main(){
    int a;
    int aa[] = {1,1,2,6,4};
    scanf("%d",&a);
    printf("%d",(a<5)?aa[a]:0);
}