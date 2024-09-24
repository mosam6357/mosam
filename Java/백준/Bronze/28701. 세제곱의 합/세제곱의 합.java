import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = (a*(a+1))/2;
        System.out.println(b);
        System.out.println(b*b);
        int sum=0;
        for(int i =1; i<a+1; i++){
            sum+=i*i*i;
        }
        System.out.println(sum);
    }
}