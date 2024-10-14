import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b= in.nextInt();
        if(a==1 || (a==2 && b<18)){
            System.out.println("Before");
        }
        else if(a==2 && b==18){
            System.out.println("Special");
        }
        else{
            System.out.println("After");
        }
    }
}