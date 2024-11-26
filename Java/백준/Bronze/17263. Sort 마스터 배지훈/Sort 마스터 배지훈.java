import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int max = 0;
        for(int i =0; i<a; i++){
            int b = in.nextInt();
            max = max>b?max:b;
        }
        System.out.println(max);
    }
}