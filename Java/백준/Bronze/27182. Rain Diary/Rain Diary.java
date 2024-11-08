import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        if(a-7<=0){
            System.out.println(b+7);
        }
        else{
            System.out.println(a-7);
        }
    }
}