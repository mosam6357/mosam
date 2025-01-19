import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int cnt = 0;
        while(a<b){
            if (a%3==0){
                a++;
            }
            else if(a%3==1){
                a*=2;
            }
            else{
                a*=3;
            }
            cnt++;
        }
        System.out.println(cnt);
    }
}