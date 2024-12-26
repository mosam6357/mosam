#include <stdio.h>

int main(){
    int a[4];
    while(true){
        for(int i=0; i<4; i++){
            scanf("%d",&a[i]);
        }
        if(a[0]==0 && a[1]==0 && a[2]==0 && a[3]==0){
            break;
        }
        int s1 = 1; int s2 = 1; int ans = 1;
        for (int i=0; i<a[1]; i++){
            s1*=a[0];
        }
        for (int i=0; i<a[2]; i++){
            s2*=s1;
        }
        for (int i=0; i<a[3]; i++){
            ans*=s2;
        }
        printf("%d\n",ans);
    }
}