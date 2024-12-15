#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    if(a<4){
        printf("%d",a);
    }
    else{
        int b=2,c=3,ans=0;
        for (int i=0; i<a-3; i++){
            ans = (b+c)%10007;
            b=c;
            c=ans;
        }
        printf("%d",ans);
    }
}