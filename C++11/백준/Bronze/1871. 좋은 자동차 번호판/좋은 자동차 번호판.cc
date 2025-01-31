#include <stdio.h>
#include <cmath>

int main(){
    int a,n2;
    char c1,c2,c3,c4;
    scanf("%d\n",&a);
    for(int i=0;i<a;i++){
        scanf("%c%c%c%c%d\n",&c1,&c2,&c3,&c4,&n2);
        int n1 = (c1-'A')*26*26+(c2-'A')*26+(c3-'A');
        if(abs(n1-n2)<=100){
            printf("nice\n");
        }
        else{
            printf("not nice\n");
        }
    }
    return 0;
}