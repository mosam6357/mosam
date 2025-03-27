import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int max = 0;
        for (int i=0;i<a;i++){
            int score = 0;
            int q = in.nextInt();
            int w = in.nextInt();
            score+=q>w?q:w;
            int[] aa = new int[5];
            for (int j=0;j<5;j++){
                aa[j] = in.nextInt();
            }
            Arrays.sort(aa);
            score+=aa[3]+aa[4];
            max = max>score?max:score;
        }
        System.out.println(max);
    }
}