import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String aa = in.next();
        String bb = in.next();
        int cnt = 0;
        for (int i=0; i<a; i++){
            if(aa.charAt(i)!=bb.charAt(i)){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}