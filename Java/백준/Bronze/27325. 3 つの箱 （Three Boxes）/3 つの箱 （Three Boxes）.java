import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int x = 1;
        int cnt = 0;
        String s = in.next();
        for (int i=0;i<a;i++){
            char c = s.charAt(i);
            if(c=='L'){
                if(x!=1){x--;}
            }
            else{
                if(x!=3){x++;}
                if(x==3){cnt++;}
            }
        }
        System.out.println(cnt);
    }
}