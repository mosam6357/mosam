#include <stdio.h>

int main(){
    char aa[26];
    scanf("%s",aa);
    int a[26] = {0,};
    for (int i =0; i<25; i++){
        a[(int)aa[i]-65]++;
    }
    for (int i=0; i<26; i++){
        if(a[i]==0){
            printf("%c",(char)(i+65));
            break;
        }
    }
}