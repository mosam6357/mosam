import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if(a%2==1){
            System.out.println("still running");
        }
        else{
            int s = 0;
            for (int i=0;i<a/2;i++){
                s+= -in.nextInt()+in.nextInt();
            }
            System.out.println(s);
        }
    }
}