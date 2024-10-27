#include <stdio.h>

int main(){
    int a,b,c,d;
    scanf("%d %d\n%d %d",&a,&b,&c,&d);
    if(b<=c || d<=a){
        printf("%d",b-a+d-c);
    }
    else{
        int max = b>d?b:d;
        int min = a<c?a:c;
        printf("%d",max-min);
    }
}