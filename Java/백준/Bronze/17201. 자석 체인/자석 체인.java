import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String s = in.next();
        for (int i=1;i<a*2;i++){
            if (s.charAt(i-1)==s.charAt(i)){
                System.out.println("No");
                break;
            }
            if (i==a*2-1){
                System.out.println("Yes");
            }
        }
    }
}