import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int sum = -1;
        for (int i=0; i<4; i++){
            sum+=in.nextInt();
        }
        System.out.println((sum%4==0)?4:sum%4);
    }
}