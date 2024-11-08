#include <stdio.h>
#include <string.h>

int main(){
    char a[51];
    scanf("%s",a);
    int i =0;
    while(i<strlen(a)){
        printf("%c",a[i]);
        i+=(int)a[i]-64;
    }
}