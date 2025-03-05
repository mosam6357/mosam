#include <stdio.h>

int main(void){
    int a;
    scanf("%d",&a);
    for (int i=0;i<a;i++){
        double n;
        scanf("%lf",&n);
        printf("$%.2lf\n",n*0.8);
    }
    return 0;
}