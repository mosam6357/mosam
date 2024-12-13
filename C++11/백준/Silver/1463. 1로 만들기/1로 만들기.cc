#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    if(a<7){
        int aa[] = {0,0,1,1,2,3,2};
        printf("%d",aa[a]);
    }
    else{
        int aa[a+1] = {0,0,1,1,2,3,2};
        for (int i=7; i<a+1; i++){
            int min = aa[i-1]+1;
            if(i%2==0){
                min = min<aa[i/2]+1?min:aa[i/2]+1;
            }
            if(i%3==0){
                min = min<aa[i/3]+1?min:aa[i/3]+1;
            }
            aa[i] = min;
        }
        printf("%d",aa[a]);
    }
}