#include <stdio.h>

int main(){
    int a = 0;
    char c[4] = {'N','E','S','W'};
    for (int i=0; i<10; i++){
        int b;
        scanf("%d",&b);
        a+=b;
    }
    printf("%c",c[a%4]);
}