import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i =0; i<a; i++){
            aa[i] = in.nextInt();
        }
        for (int i=0; i<a; i++){
            if(aa[i]<250){
                System.out.printf("4 ");
            }
            else{
                System.out.printf("%d ",13-aa[i]/25);
            }
        }
    }
}