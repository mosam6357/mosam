using System;
using System.Linq;
public class Solution {
    public int solution(int a, int b) {
        int[] aa = {int.Parse(a.ToString()+b.ToString()),int.Parse(b.ToString()+a.ToString())};
        int answer = aa.Max();
        return answer;
    }
}