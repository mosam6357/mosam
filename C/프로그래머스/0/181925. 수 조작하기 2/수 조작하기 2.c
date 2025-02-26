#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// numLog_len은 배열 numLog의 길이입니다.
char* solution(int numLog[], size_t numLog_len) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    char* answer = (char*)malloc(numLog_len);
        for (int i=0;i<numLog_len-1;i++){
            int n = numLog[i+1]-numLog[i];
            if (n==1){
                answer[i]='w';
            }
            else if (n==-1){
                answer[i]='s';
            }
            else if(n==10){
                answer[i]='d';
            }
            else{
                answer[i]='a';
            }
        }
    answer[numLog_len-1]='\0';
    return answer;
}