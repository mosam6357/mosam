import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String s = in.next();
        int cnt = 1;
        for (int i=0;i<s.length();i++){
            if (s.charAt(i)==','){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}