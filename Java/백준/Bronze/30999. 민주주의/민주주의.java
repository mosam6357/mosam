import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int cnt = 0;
        for (int i=0; i<a; i++){
            String s = in.next();
            int o = 0;
            for (int j =0; j<b; j++){
                if(s.charAt(j)=='O'){
                    o++;
                }
                else{
                    o--;
                }
            }
            if(o>0){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}