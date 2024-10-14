import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        int cost = 0;
        for (int i=0; i<a; i++){
            aa[i] = in.nextInt();
        }
        int b = in.nextInt();
        for (int i=0; i<b; i++){
            cost+=aa[in.nextInt()-1];
        }
        System.out.println(cost);
    }
}