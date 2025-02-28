using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        if (my_string.Length<is_prefix.Length){
            return 0;
        }
        if (my_string.Substring(0,is_prefix.Length).Equals(is_prefix)){
            return 1;
        }
        return 0;
    }
}