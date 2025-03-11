import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            int a = in.nextInt();
            if(a==0){
                break;
            }
            System.out.printf("%d => %d\n",a,a*(a-1)+1);
        }
    }
}