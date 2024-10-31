import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            int b = in.nextInt();
            int j = 1;
            while(j*j+j<=b){
                j++;
            }
            System.out.println(j-1);
        }
    }
}