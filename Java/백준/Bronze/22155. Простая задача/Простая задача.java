import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for (int i=0; i<q; i++){
            int a = in.nextInt();
            int b = in.nextInt();
            if((a<=1 && b<=2) || (a<=2 && b<=1)){
                System.out.println("Yes");
            }
            else{
                System.out.println("No");
            }
        }
    }
}