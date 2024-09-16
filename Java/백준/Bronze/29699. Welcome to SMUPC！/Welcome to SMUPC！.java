import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = "WelcomeToSMUPC";
        int b = in.nextInt();
        int c = b%14;
        if(c==0){
            System.out.println("C");
        }
        else{
            System.out.println(a.charAt(c-1));
        }
    }
}