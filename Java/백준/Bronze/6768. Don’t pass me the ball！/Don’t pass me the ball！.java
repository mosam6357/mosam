import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int n = 1;
        for (int i=1;i<a;i++){
            if (i>a-4){
                n*=i;
            }
        }
        System.out.println(n/6);
    }
}