import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt()*7;
        int b = in.nextInt()*13;
        if(a==b){
            System.out.println("lika");
        }
        else if(a>b){
            System.out.println("Axel");
        }
        else{
            System.out.println("Petra");
        }
    }
}