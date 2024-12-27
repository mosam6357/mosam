#include <stdio.h>

int main(){
    int n,a,b;
    scanf("%d %d %d",&n,&a,&b);
    int c1=0,c2=0,c3=0;
    for (int i=1; i<n+1; i++){
        if(i%a==0 && i%b==0){
            c3++;
        }
        else if(i%a==0){
            c1++;
        }
        else if(i%b==0){
            c2++;
        }
    }
    printf("%d %d %d",c1,c2,c3);
}