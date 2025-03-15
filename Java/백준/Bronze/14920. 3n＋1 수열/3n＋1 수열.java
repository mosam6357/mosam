import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a =  in.nextInt();
        int cnt = 1;
        while(a!=1){
            if (a%2==0){
                a/=2;
            }
            else{
                a = a*3+1;
            }
            cnt++;
        }
        System.out.println(cnt);
    }
}