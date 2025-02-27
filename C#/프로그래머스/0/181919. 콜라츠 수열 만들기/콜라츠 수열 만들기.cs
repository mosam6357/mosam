using System;
using System.Collections;

public class Solution {
    public ArrayList solution(int n) {
        ArrayList answer = new ArrayList();
        answer.Add(n);
        while(n!=1){
            if(n%2==0){
                n/=2;
            }
            else{
                n*=3;
                n++;
            }
            answer.Add(n);
        }
        return answer;
    }
}