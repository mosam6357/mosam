import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        float q = in.nextFloat();
        int a = in.nextInt();
        float e = 0;
        for (int i=0;i<a;i++){
            e+=in.nextFloat()*in.nextFloat();
        }
        System.out.println(q*e);
    }
}