#include <stdio.h>
#include <ctype.h>

int main(){
    char a[1000001];
    scanf("%s",a);
    for (int i=0; a[i]!=NULL; i++){
        a[i] = toupper(a[i]);
    }
    printf("%s",a);
}