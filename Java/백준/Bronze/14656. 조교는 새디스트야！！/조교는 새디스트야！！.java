import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt = 0;
        for (int i=1;i<=a;i++){
            if (in.nextInt()!=i){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}