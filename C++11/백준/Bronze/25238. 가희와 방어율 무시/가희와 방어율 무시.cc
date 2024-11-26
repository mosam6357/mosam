#include <stdio.h>

int main(){
    float a,b;
    scanf("%f %f",&a,&b);
    printf("%d",(a-a*(b/100)>=100)?0:1);
}