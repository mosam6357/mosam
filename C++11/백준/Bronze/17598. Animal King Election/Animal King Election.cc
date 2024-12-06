#include <stdio.h>

int main(){
    char a[100];
    int cnt=0;
    for (int i=0; i<9; i++){
        scanf("%s",a);
        if(a[0]=='L'){
            cnt++;
        }
    }
    if(cnt>=5){
        printf("Lion");
    }
    else{
        printf("Tiger");
    }
}