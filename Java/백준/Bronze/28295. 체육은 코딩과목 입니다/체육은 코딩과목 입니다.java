import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = 0;
        String[] aa = {"N","E","S","W"};
        for (int i=0; i<10; i++){
            a+=in.nextInt();
        }
        System.out.println(aa[a%4]);
    }
}