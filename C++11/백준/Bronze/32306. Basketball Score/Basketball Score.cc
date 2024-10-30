#include <stdio.h>

int main(){
    int aa[] = {0,0};
    for (int i=0; i<2; i++){
        int a,b,c;
        scanf("%d %d %d",&a,&b,&c);
        aa[i] = a+b*2+c*3;
    }
    if(aa[0]==aa[1]){
        printf("0");
    }
    else{
        printf("%d",aa[0]>aa[1]?1:2);
    }
}