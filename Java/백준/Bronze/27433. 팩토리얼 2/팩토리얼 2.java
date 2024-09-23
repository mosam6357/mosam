import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); long ans =1;
        for(int i=0; i<a; i++){
            ans*=i+1;
        }
        System.out.println(ans);
    }
}