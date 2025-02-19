using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int a = 1;
        for (int i=0;i<num_list.Length;i++){
            a*=num_list[i];
        }
        if (a<Math.Pow(num_list.Sum(),2)){
            return 1;
        }
        return 0;
    }
}