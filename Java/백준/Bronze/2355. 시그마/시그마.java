import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        long q = in.nextLong();
        long w = in.nextLong();
        long b = q>w?q:w; //big
        long s = q<w?q:w; //small
        System.out.println((b*(b+1)-s*(s-1))/2);
    }
}