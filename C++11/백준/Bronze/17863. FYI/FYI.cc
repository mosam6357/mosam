#include <stdio.h>

int main(){
    char a[8];
    scanf("%s",a);
    for (int i=0; i<3;i++){
        if(a[i]!='5'){
            printf("NO");
            break;
        }
        if(i==2){
            printf("YES");
        }
    }
}