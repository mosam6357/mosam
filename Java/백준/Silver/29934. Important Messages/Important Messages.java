import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt = 0;
        String[] aa = new String[a];
        for (int i=0;i<a;i++){
            aa[i] = in.next();
        }
        int b = in.nextInt();
        for (int i=0;i<b;i++){
            String s = in.next();
            for (int j=0;j<a;j++){
                if(s.equals(aa[j])){
                    cnt++;
                    break;
                }
            }
        }
        System.out.println(cnt);
    }
}