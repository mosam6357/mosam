#include <stdio.h>

int main(){
    int a,b,cnt=0;
    scanf("%d %d",&a,&b);
    char p[1001][1001];
    for (int i=0;i<a;i++){
        scanf("%s",p[i]);
    }
    for (int i=0;i<a;i++){
        for (int j=0;j<b-1;j++){
            if (p[i][j]==p[i][j+1] && p[i][j]=='.')cnt++;
        }
    }
    for (int i=0;i<b;i++){
        for (int j=0;j<a-1;j++){
            if (p[j][i]==p[j+1][i] && p[j][i]=='.')cnt++;
        }
    }
    printf("%d",cnt);
}