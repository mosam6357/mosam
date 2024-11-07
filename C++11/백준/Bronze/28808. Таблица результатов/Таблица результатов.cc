#include <stdio.h>
#include <string.h>

int main(){
    int a,b;
    int cnt=0;
    scanf("%d %d",&a,&b);
    for(int i=0; i<a; i++){
        char c[b];
        scanf("%s",c);
        for(int j =0; j<strlen(c); j++){
            if(c[j]=='+'){
                cnt++;
                break;
            }
        }
    }
    printf("%d",cnt);
}