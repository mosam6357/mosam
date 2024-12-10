#include <stdio.h>

int main(){
    int t1,t2,t;
    int a[6];
    for (int i=0; i<3; i++){
        for (int j=0; j<6; j++){
            scanf("%d",&a[j]);
        }
        t1 = a[0]*3600+a[1]*60+a[2];
        t2 = a[3]*3600+a[4]*60+a[5];
        t = t2-t1;
        printf("%d %d %d\n",t/3600,(t%3600)/60,t%60);
    }
}