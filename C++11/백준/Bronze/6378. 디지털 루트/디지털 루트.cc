#include <string.h>
#include <stdio.h>

int dsum(char a[]){
    int sum=0;
    for(int i=0; i<strlen(a); i++){
        sum += a[i]-'0';
    }
    while(sum>=10){
        sum = sum/10+sum%10;
    }
    return sum;
}
int main(){
    char a[1001];
    while(1){
        scanf("%s",a);
        if(a[0]=='0')break;
        printf("%d\n",dsum(a));
    }
}