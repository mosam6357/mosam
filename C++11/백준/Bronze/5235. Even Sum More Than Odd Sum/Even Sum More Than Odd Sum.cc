#include <stdio.h>

int main(){
    int a,b,c;
    scanf("%d",&a);
    for(int i=0; i<a; i++){
        scanf("%d",&b);
        int s =0;
        for(int j=0; j<b; j++){
            scanf("%d",&c);
            if(c%2==0){
                s+=c;
            }
            else{
                s-=c;
            }
        }
        if(s==0){
            printf("TIE\n");
        }
        else{
            printf("%s\n",(s>0)?"EVEN":"ODD");
        }
    }
}