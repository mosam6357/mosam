import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        float a = in.nextFloat();
        float b = in.nextFloat();
        if(a-a*(b/100)>=100){
            System.out.println(0);
        }
        else{
            System.out.println(1);
        }
    }
}