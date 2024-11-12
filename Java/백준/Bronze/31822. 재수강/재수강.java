import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String q = in.next();
        int a = in.nextInt();
        int cnt=0;
        for(int i=0; i<a; i++){
            String b =in.next();
            for(int j=0; j<5; j++){
                if(q.charAt(j)!=b.charAt(j))break;
                if(j==4)cnt++;
            }
        }
        System.out.println(cnt);
    }
}