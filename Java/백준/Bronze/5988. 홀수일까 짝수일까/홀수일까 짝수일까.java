import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            String s = in.next();
            if ((int)s.charAt(s.length()-1)%2==0){
                System.out.println("even");
            }
            else{
                System.out.println("odd");
            }
        }
        
    }
}