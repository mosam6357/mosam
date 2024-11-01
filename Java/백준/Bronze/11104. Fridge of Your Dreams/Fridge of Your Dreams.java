import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            String b = in.next();
            int ans = 0;
            int sqrt = 1;
            for (int j =0; j<24; j++){
                if(b.charAt(23-j)=='1'){
                    ans += sqrt;
                }
                sqrt*=2;
            }
            System.out.println(ans);
        }
    }
}