#include <stdio.h>

int main(){
    int a,b;
    char c[a+1];
    scanf("%d %d",&a,&b);
    scanf("%s",c);
    int p = 1;
    int f = 0;
    for (int i=0;i<a;i++){
        if(c[i]=='L'){
            if(p==0)f++;
            p=0;
        }
        else{
            if(p==1)f++;
            p=1;
        }
    }
    printf("%d",(f>b)?0:b-f);
}