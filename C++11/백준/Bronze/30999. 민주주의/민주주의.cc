#include <stdio.h>
#include <string.h>

int main(){
    int a,b,cnt=0;
    scanf("%d %d",&a,&b);
    for (int i=0; i<a; i++){
        char c[100];
        scanf("%s",c);
        int o = 0;
        for (int j=0; j<strlen(c);j++){
            if(c[j]=='O'){
                o++;
            }
            else{
                o--;
            }
        }
        if(o>0)cnt++;
    }
    printf("%d",cnt);
}