import java.util.Scanner;
import java.math.BigInteger;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if(a<=1){
            System.out.println(a);
        }
        else{
            BigInteger n1 = new BigInteger("0");
            BigInteger n2 = new BigInteger("1");
            for (int i=0;i<a-1;i++){
                BigInteger ans =  n1.add(n2);
                n1 = n2;
                n2 = ans;
            }
            System.out.println(n2);
        }
    }
}