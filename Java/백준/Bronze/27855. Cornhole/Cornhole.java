import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt()*3+in.nextInt();
        int b = in.nextInt()*3+in.nextInt();
        if(a==b){
            System.out.println("NO SCORE");
        }
        else{
            System.out.printf("%d %d",a>b?1:2,a>b?a-b:b-a);
        }
    }
}