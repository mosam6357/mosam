import java.util.ArrayList;

class Solution {
    public ArrayList<Integer> solution(int n) {
        ArrayList<Integer> answer = new ArrayList<>();
        answer.add(n);
        while(n!=1){
            if (n%2==0){
                n/=2;
            }
            else{
                n=n*3+1;
            }
            answer.add(n);
        }
        return answer;
    }
}