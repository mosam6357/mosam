import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        StringBuilder sb = new StringBuilder();
        for (int i=0;i<a;i++){
            sb.append("a");
        }
        System.out.println(sb.toString());
    }
}