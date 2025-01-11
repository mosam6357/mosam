import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<9;i++){
            a-=in.nextInt();
        }
        System.out.println(a);
    }
}