import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = {1,1,2,6,4};
        for (int i=0; i<a; i++){
            int b =in.nextInt();
            if(b>4){
                System.out.println(0);
            }
            else{
                System.out.println(aa[b]);
            }
        }
    }
}