using System;

public class Solution {
    public int solution(int[] num_list) {
        int n1=0,n2=0;
        for (int i=0;i<num_list.Length;i++){
            if (i%2==0){
                n2+=num_list[i];
            }
            else{
                n1+=num_list[i];
            }
        }
        return Math.Max(n1,n2);
    }
}