import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        long ans = 0;
        for (int i=0;i<a;i++){
            if(i==0){
                ans = 5;
            }
            else{
                ans+=(i+2)*3-2;
            }
        }
        System.out.println(ans%45678);
    }
}