import java.util.Scanner;
import java.math.BigInteger;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        BigInteger a = in.nextBigInteger();
        BigInteger b = in.nextBigInteger();
        BigInteger c = a.divide(b);
        BigInteger d = a.mod(b);
        System.out.println(c);
        System.out.println(d);
    }
}