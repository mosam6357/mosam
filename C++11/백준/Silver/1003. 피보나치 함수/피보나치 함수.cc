#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d",&a);
    for (int i=0; i<a; i++){
        scanf("%d",&b);
        if(b==0 || b==1){
            printf("%d %d\n",1-b,b);
        }
        else{
            int z[b+1] = {1,0};
            int o[b+1] = {0,1};
            for (int j=2; j<b+1; j++){
                z[j] = z[j-1]+z[j-2];
                o[j] = o[j-1]+o[j-2];
            }
            printf("%d %d\n",z[b],o[b]);
        }
    }
}