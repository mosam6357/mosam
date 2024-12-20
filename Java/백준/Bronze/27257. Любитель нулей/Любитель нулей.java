import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        int ck = 0;
        int cnt = 0;
        for (int i=a.length()-1; i>-1; i--){
            if(ck==0 && a.charAt(i)!='0'){
                ck = 1;
            }
            if(ck==1 && a.charAt(i)=='0'){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}