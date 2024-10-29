import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        if(a<b*0.2){
            System.out.println("weak");
        }
        else if(a<b*0.4){
            System.out.println("normal");
        }
        else if(a<b*0.6){
            System.out.println("strong");
        }
        else{
            System.out.println("very strong");
        }
    }
}