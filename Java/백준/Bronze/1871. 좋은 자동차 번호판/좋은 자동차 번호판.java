import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for (int i=0;i<q;i++){
            String[] aa = in.next().split("-");
            int a = Integer.parseInt(aa[1]);
            int p = 26*26;
            int b = 0;
            for (int j=0;j<3;j++){
                b+=(aa[0].charAt(j)-'A')*p;    
                p/=26;
            }
            if(Math.abs(a-b)<=100){
                System.out.println("nice");
            }
            else{
                System.out.println("not nice");
            }
        }
    }
}