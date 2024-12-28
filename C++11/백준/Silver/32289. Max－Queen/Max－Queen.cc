#include <stdio.h>

int main(){
    long long a,b;
    scanf("%lld %lld",&a,&b);
    long long s[] = {0,b-1,a-1,a-1,(a-1)*(b-2)};
    long long sum = 0;
    for (int i=0; i<5; i++){
        sum+=i*s[i];
    }
    printf("%lld",sum);
}