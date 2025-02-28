import java.util.List;
import java.util.ArrayList;

class Solution {
    public int[] solution(int n, int k) {
        List<Integer> answer = new ArrayList<Integer>();
        for (int i=1;i<=n;i++){
            if (i%k==0){
                answer.add(i);
            }
        }
        return answer.stream().mapToInt(i->i).toArray();
    }
}