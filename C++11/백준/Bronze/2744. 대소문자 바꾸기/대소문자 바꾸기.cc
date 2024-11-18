#include <stdio.h>

int main(){
    char a[101];
    scanf("%s",a);
    for(int i =0; a[i]!='\0'; i++){
        if(a[i]<97){
            printf("%c",(char)a[i]+32);
        }
        else{
            printf("%c",(char)a[i]-32);
        }
    }
}