import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int sum = 0;
        for (int i=1;i<a+1;i++){
            if(a%i==0){
                sum+=i;
            }
        }
        System.out.println(sum);
    }
}