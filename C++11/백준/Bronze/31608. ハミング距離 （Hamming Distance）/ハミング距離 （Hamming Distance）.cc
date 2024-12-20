#include <stdio.h>

int main(){
    int a, cnt=0;
    scanf("%d",&a);
    char aa[a+1];
    char bb[a+1];
    scanf("%s\n%s",aa,bb);
    for (int i=0; i<a; i++){
        if(aa[i]!=bb[i])cnt++;
    }
    printf("%d",cnt);
}