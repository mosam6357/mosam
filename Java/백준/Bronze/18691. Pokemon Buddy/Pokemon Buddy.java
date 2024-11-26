import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for(int i=0; i<a;i++){
            int b = in.nextInt();
            int c = in.nextInt();
            int d = in.nextInt();
            if(c>=d){System.out.println(0);}
            else{System.out.println((d-c)*(b*2-1));}
        }
    }
}