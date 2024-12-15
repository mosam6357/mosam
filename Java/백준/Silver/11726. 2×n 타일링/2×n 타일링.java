import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if(a<4){
            System.out.println(a);
        }
        else{
            int b1 = 2;
            int b2 = 3;
            int ans = 0;
            for(int i=0;i<a-3;i++){
                ans = (b1+b2)%10007;
                b1=b2;
                b2=ans;
            }
            System.out.println(ans);
        }
    }
}