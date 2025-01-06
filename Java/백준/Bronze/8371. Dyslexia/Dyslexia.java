import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String s1 = in.next();
        String s2 = in.next();
        int cnt = 0;
        for (int i=0;i<a;i++){
            if(s1.charAt(i)!=s2.charAt(i)){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}