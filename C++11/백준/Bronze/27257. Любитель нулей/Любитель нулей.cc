#include <stdio.h>
#include <string.h>

int main(){
    char a[10];
    scanf("%s",a);
    int ck = 0;
    int cnt = 0;
    int len = strlen(a);
    for (int i=len-1; i>-1; i--){
        if(ck==0 && a[i]!='0'){
            ck=1;
        }
        if(ck==1 && a[i]=='0'){
            cnt++;
        }
    }
    printf("%d",cnt);
}