import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int cnt = 0;
        for (int i=0; i<a; i++){
            String c = in.next();
            for (int j =0; j<b; j++){
                if(c.charAt(j)=='+'){
                    cnt++;
                    break;
                }
            }
        }
        System.out.println(cnt);
    }
}