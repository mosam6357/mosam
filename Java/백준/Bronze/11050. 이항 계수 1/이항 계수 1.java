import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = 1; int d =1;
        for(int i =0; i<a; i++){
            c*=i+1;
        }
        for(int j=0; j<b; j++){
            d*=j+1;
        }
        for (int k=0; k<a-b; k++){
            d*=k+1;
        }
        System.out.println(c/d);
    }
}