import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        double q = (double)a;
        double sum = 0;
        for (int i=0;i<a;i++){
            double w = in.nextDouble();
            if (w==-1){
                q--;
            }
            else{
                sum+=w;
            }
        }
        System.out.println(sum/q);
    }
}