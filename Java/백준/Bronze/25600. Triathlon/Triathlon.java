import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        int ans = 0;
        int max = 0;
        for (int i =0; i<q; i++){
            int a = in.nextInt();
            int b = in.nextInt();
            int c = in.nextInt();
            int score = a*(b+c);
            if(a==b+c){
                score*=2;
            }
            max = max>score?max:score;
        }
        System.out.println(max);
    }
}