import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int total = 0;
            int a = in.nextInt();
            for (int j=1;j<=a+1;j++){
                total+=(j-1)*j*(j+1)/2;
            }
            System.out.println(total);
        }
    }
}