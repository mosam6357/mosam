import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String b = in.next();
        int cnt = 0;
        for (int i=0; i<a; i++){
            if(b.charAt(i)=='o'){
                cnt++;
            }
            else{
                cnt+=2;
            }
        }
        System.out.println(cnt);
    }
}