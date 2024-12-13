#include <stdio.h>

int main(){
    int cnt=0;
    char c;
    for (int i=0; i<6; i++){
        c = getchar();
        getchar();
        if(c=='W')cnt++;
    }
    if(cnt==0){
        printf("-1");
    }
    else if(cnt<=2){
        printf("3");
    }
    else if(cnt<=4){
        printf("2");
    }
    else{
        printf("1");
    }
}