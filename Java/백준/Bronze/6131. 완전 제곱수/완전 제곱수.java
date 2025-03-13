import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt = 0;
        for (int i=2;i<1000;i++){
            for (int j=1;j<i;j++){
                if (i*i==j*j+a){
                    cnt++;
                }
            }
        }
        System.out.println(cnt);
    }
}