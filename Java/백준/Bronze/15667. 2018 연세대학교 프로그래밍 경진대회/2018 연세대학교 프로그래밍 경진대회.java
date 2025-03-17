import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for(int i=1;i<101;i++){
            if (a==i*i+i+1){
                System.out.println(i);
                break;
            }
        }
    }
}