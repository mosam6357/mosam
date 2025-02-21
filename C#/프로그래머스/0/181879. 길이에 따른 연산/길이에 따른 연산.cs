using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 1;
        if (num_list.Length>10){
            return num_list.Sum();
        }
        for (int i=0;i<num_list.Length;i++){
            answer*=num_list[i];
        }
        return answer;
    }
}