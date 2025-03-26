import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        double a = in.nextInt();
        String s = in.next();
        double n = s.length()-a*7.5;
        if (n==0){
            System.out.println("bigdata? security!");
        }
        else if(n>0){
            System.out.println("security!");
        }
        else{
            System.out.println("bigdata?");
        }
    }
}