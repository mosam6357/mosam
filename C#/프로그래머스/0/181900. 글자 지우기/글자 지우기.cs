using System;

public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = "";
        int[] aa = new int[my_string.Length];
        for (int i=0;i<indices.Length;i++){
            aa[indices[i]]=1;
        }
        for (int i=0;i<my_string.Length;i++){
            if (aa[i]==0){
                answer+=my_string[i];
            }
        }
        return answer;
    }
}