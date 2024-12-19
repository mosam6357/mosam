#include <stdio.h>

int main(){
    double w,h,bmi;
    scanf("%lf\n%lf",&w,&h);
    bmi = w/(h*h);
    if(bmi<18.5){
        printf("Underweight");
    }
    else if(bmi>25){
        printf("Overweight");
    }
    else{
        printf("Normal weight");
    }
}