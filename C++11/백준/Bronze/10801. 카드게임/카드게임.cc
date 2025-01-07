#include <stdio.h>

int main(){
    int a[10];
    int b[10];
    int cnt = 0;
    for (int i=0;i<10;i++){
        scanf("%d",&a[i]);
    }
    for (int i=0;i<10;i++){
        scanf("%d",&b[i]);
    }
    for (int i=0;i<10;i++){
        if (a[i]>b[i]){cnt++;}
        else if(a[i]<b[i]){cnt--;}
    }
    if (cnt ==0){
        printf("D");
    }
    else{
        printf((cnt>0)?"A":"B");
    }
}