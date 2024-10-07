import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt=0;
        String[] aa = new String[a];
        for (int i =0; i<a; i++){
            aa[i] = in.next();
        }
        String b = in.next();
        for (int i =0; i<a; i++){
            if(b.equals(aa[i])){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}