import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = 1;
        while(a>b){
            b*=2;
        }
        if(a==b){System.out.println(1);}
        else{
            System.out.println(0);
        }
    }
}