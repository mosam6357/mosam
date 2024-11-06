import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = {in.nextInt(),in.nextInt()};
        int[] b = {in.nextInt(),in.nextInt()};
        if(b[0]<0 && b[1]>=10){System.out.println("A storm warning for tomorrow! Be careful and stay home if possible!");}
        else if(b[0]<a[0]){System.out.println("MCHS warns! Low temperature is expected tomorrow.");}
        else if(b[1]>a[1]){System.out.println("MCHS warns! Strong wind is expected tomorrow.");}
        else{System.out.println("No message");}
    }
}