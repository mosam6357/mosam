import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String s = in.next();
        int cnt = 0;
        for (int i=0;i<a;i++){
            if (s.charAt(i)!=s.charAt(a-1-i)){
                cnt++;
            }
        }
        System.out.println(cnt/2);
    }
}