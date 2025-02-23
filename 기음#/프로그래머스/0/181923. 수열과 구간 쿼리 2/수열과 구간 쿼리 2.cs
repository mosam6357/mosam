using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        for (int i=0;i<queries.GetLength(0);i++){
            int  min = 1000001;
            for (int j=queries[i,0];j<=queries[i,1];j++){
                if (arr[j]>queries[i,2]){
                    min = arr[j]<min?arr[j]:min;
                }
            }
            answer[i] = min==1000001?-1:min;
        }
        return answer;
    }
}