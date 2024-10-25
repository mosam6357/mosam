#include <stdio.h>

int main(){
    int a;
    scanf("%d",&a);
    for(int i =0; i<a; i++){
        int aa[3];
        scanf("%d %d %d",&aa[0],&aa[1],&aa[2]);
        int min = aa[0]<aa[1]?aa[0]:aa[1];
        min = min<aa[2]?min:aa[2];
        printf("%d\n",min);
    }
}