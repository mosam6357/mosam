using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        int lo = overwrite_string.Length;
        string answer = my_string.Substring(0,s)+overwrite_string+my_string.Substring(s+lo);
        return answer;
    }
}