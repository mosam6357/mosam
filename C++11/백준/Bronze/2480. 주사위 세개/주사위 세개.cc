#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d %d %d",&a,&b,&c);
    if(a==b && b==c){
        printf("%d",10000+b*1000);
    }
    else if(a!=b && b!=c && c!=a){
        int max = a>b?a:b;
        if(max == a){
            max = a>c?a:c;
        }
        else{
            max = b>c?b:c;
        }
        printf("%d",max*100);
    }
    else{
        if(a==b){
            printf("%d",1000+a*100);
        }
        else if(b==c){
            printf("%d",1000+b*100);
        }
        else{
            printf("%d",1000+c*100);
        }
    }
}