#include <stdio.h>

int main(){
    int a,b;
    scanf("%d",&a);
    for(int i=0; i<a;i++){
        scanf("%d",&b);
        if(b<4){
            printf("%d\n",1);
        }
        else{
            long long c1 = 1; long long c2=1; long long c3=1; long long ans =0;
            for(int j=0;j<b-3;j++){
                ans=c1+c2;
                c1=c2;
                c2=c3;
                c3=ans;
            }
            printf("%lld\n",ans);
        }
    }
}