import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        int i =0;
        while(i<a.length()){
            System.out.printf("%c",a.charAt(i));
            i+=(int)(a.charAt(i))-64;
        }
    }
}