import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = 1000-in.nextInt();
        System.out.println(a/500+(a%500)/100+(a%100)/50+(a%50)/10+(a%10)/5+a%5);
    }
}