#include <stdio.h>

double score(double s){
    int b;
    scanf("%d",&b);
    s+=b*13;
    scanf("%d",&b);
    s+=b*7;
    scanf("%d",&b);
    s+=b*5;
    scanf("%d",&b);
    s+=b*3;
    scanf("%d",&b);
    s+=b*3;
    scanf("%d",&b);
    s+=b*2;
    return s;
}
int main(){
    double s1=0,s2=1.5;
    s1=score(s1);
    s2=score(s2);
    if(s1>s2){
        printf("cocjr0208");
    }
    else{
        printf("ekwoo");
    }
}