import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        int b = in.nextInt();
        int cnt = 0;
        for (int i =0; i<b; i++){
            if(a.equals(in.next())){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}