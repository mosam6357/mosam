class Solution {
    public int solution(int a, int b) {
        int n1 = Integer.parseInt(String.valueOf(a)+String.valueOf(b));
        int n2 = Integer.parseInt(String.valueOf(b)+String.valueOf(a));
        int answer = n1>n2?n1:n2;
        return answer;
    }
}