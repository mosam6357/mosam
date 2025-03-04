import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int p = 0;
        int max = 0;
        for (int i=0;i<10;i++){
            int a = in.nextInt();
            int b = in.nextInt();
            p += b-a;
            max = max>p?max:p;
        }
        System.out.println(max);
    }
}