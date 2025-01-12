import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for(int i =0; i<a; i++){
            int b = in.nextInt(); int c = in.nextInt();
            if(c>b){
                System.out.println("NO BRAINS");
            }
            else{
                System.out.println("MMM BRAINS");
            }
        }
    }
}