import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            int a = in.nextInt();
            if (a==0){
                break;
            }
            int total = 0;
            for (int i=1;i<=a;i++){
                total += i*i;
            }
            System.out.println(total);
        }
    }
}