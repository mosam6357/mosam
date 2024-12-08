#include <stdio.h>

int gcd(int a,int b){ //최대공약수 구하는 함수(유클리드 호제법)
    if(b==0)return a;
    return gcd(b,a%b);
}
int main(){
    int a,b,d,m;
    scanf("%d %d",&a,&b);
    if(b>a){
        int temp = a;
        a = b;
        b = temp;
    }
    d = gcd(a,b);
    m = a*b/d; //최소공배수 = (두 수의 곱) / 최소공약수
    printf("%d\n%d",d,m);
}