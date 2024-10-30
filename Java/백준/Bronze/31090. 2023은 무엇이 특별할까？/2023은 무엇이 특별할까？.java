import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            int b = in.nextInt();
            int c = b%100;
            if((b+1)%c==0){
                System.out.println("Good");
            }
            else{
                System.out.println("Bye");
            }
        }
    }
}