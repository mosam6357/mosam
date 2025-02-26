import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        if(a.charAt(0)==a.charAt(1)){
            System.out.println(1);
        }
        else{
            System.out.println(0);
        }
    }
}