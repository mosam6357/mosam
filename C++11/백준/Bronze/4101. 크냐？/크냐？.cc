#include <stdio.h>

int main(){
    int a,b;
    while(1){
        scanf("%d %d",&a,&b);
        if(a==b && a==0){
            break;
        }
        printf("%s\n",(a>b)?"Yes":"No");
    }
}