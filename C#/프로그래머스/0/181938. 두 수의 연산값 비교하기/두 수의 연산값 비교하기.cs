using System;
using System.Linq;

public class Solution {
    public int solution(int a, int b) {
        int[] aa  = {int.Parse($"{a}{b}"),2*a*b};
        int answer = aa.Max();
        return answer;
    }
}