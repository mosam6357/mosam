import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt(); int sum=0;
        for(int i =0; i<q; i++){
            int w = Integer.parseInt(in.next().substring(2));
            if(w<=90){
                sum++;
            }
        }
        System.out.println(sum);
    }
}