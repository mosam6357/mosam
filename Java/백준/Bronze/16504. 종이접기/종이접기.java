import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        long total = 0;
        for (int i=0;i<a*a;i++){
            total+=in.nextInt();
        }
        System.out.println(total);
    }
}