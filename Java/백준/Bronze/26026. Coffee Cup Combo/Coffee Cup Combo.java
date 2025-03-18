import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String s = in.next();
        int c = 0;
        int cnt = 0;
        for (int i=0;i<a;i++){
            if (s.charAt(i)=='1'){
                c=3;
            }
            if (c>0){
                cnt++;
                c--;
            }
        }
        System.out.println(cnt);
    }
}