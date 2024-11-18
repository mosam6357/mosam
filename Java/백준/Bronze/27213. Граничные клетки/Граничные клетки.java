import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = a*b;
        int d = (a-2)*(b-2);
        if(a>2 && b>2){
            System.out.println(c-d);
        }
        else{
            System.out.println(c);
        }
    }
}