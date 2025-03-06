import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            int b = in.nextInt();
            int sum = 0;
            for (int j=0;j<b;j++){
                sum+=in.nextInt();
            }
            System.out.println(sum);
        }
    }
}