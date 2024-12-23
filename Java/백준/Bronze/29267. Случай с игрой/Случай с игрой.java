import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int save = 0;
        int cnt = 0;
        for (int i=0; i<a; i++){
            String s = in.next();
            if(s.charAt(1)=='a'){
                save = cnt;
                System.out.println(cnt);
            }
            if(s.charAt(1)=='o'){
                cnt = save;
                System.out.println(cnt);
            }
            if(s.charAt(1)=='h'){
                System.out.println(--cnt);
            }
            if(s.charAt(1)=='m'){
                cnt+=b;
                System.out.println(cnt);
            }
        }
    }
}