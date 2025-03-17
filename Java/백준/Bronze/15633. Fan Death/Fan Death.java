import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int total = 0;
        for (int i=1;i<=a;i++){
            if (a%i==0){
                total+=i;
            }
        }
        System.out.println(total*5-24);
    }
}