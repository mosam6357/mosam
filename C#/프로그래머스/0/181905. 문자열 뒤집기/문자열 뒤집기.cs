using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = my_string.Substring(0,s);
        answer += new String(my_string.Substring(s,e+1-s).Reverse().ToArray());
        answer += my_string.Substring(e+1);
        return answer;
    }
}