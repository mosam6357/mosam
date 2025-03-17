import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int n =  in.nextInt();
            int total = 0;
            for (int j=1;j<=n;j++){
                total+=j*j;
            }
            System.out.println(total);
        }
    }
}