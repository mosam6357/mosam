using System;

public class Solution {
    public int solution(int n) {
        if (n%2==1){
            return ((n+1)/2)*((n+1)/2);
        }
        else{
            int answer = 0;
            for (int i=2;i<=n;i+=2){
                answer+=i*i;
            }
            return answer;
        }
        
    }
}