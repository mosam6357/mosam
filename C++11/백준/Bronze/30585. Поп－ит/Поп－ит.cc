#include <stdio.h>

int main(){
    int a,b;
    scanf("%d %d",&a,&b);
    int zsum=0;
    int osum=0;
    for (int i=0; i<a; i++){
        char c[100];
        scanf("%s",c);
        for (int j=0; j<b;j++){
            if(c[j]=='0'){
                zsum++;
            }
            else{
                osum++;
            }
        }
    }
    printf("%d",(zsum<osum)?zsum:osum);
}