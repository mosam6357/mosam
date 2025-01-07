#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(){
    char a[10];
    scanf("%s",a);
    int b = atoi(a);
    int ck = 0;
    for (int i=0;i<strlen(a);i++){
        if (a[i]=='7')ck=1;
    }
    if (ck==1){
        if (b%7==0){
            printf("3");
        }
        else{
            printf("2");
        }
    }
    else{
        if (b%7==0){
            printf("1");
        }
        else{
            printf("0");
        }
    }
}