import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            int b=in.nextInt();
            if(b<=3){
                System.out.println(1);
            }
            else{
                long c1 = 1;
                long c2 = 1;
                long c3 = 1;
                long ans = 0;
                for(int j=0; j<b-3; j++){
                    ans = c1+c2;
                    c1 = c2;
                    c2 = c3;
                    c3 = ans;
                }
                System.out.println(ans);
            }
        }
    }
}