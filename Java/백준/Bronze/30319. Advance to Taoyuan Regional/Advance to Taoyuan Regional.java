import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] a = in.nextLine().split("-");
        int b = Integer.parseInt(a[1]);
        int c = Integer.parseInt(a[2]);
        if (b<9 || (b==9 && c<=16)){
            System.out.println("GOOD");
        }
        else{
            System.out.println("TOO LATE");
        }
    }
}