#include <stdio.h>

int main(){
    char a[50];
    scanf("%s",a);
    int cnt1 = 0;
    int cnt2 = 0;
    for (int i=0; a[i]!=NULL; i++){
        char b = a[i];
        if(b=='a' || b=='e' ||b=='i'||b=='o'||b=='u')cnt1++;
        if(b=='y')cnt2++;
    }
    printf("%d %d",cnt1,cnt1+cnt2);
}