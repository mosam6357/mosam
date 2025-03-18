import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[4];
        for (int i=0;i<4;i++){
            aa[i] = in.nextInt();
        }
        System.out.println(aa[0]*aa[2]);
    }
}