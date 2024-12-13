import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int cnt = 0;
        for (int i=0; i<6; i++){
            String a = in.next();
            if(a.charAt(0)=='W'){
                cnt++;
            }
        }
        System.out.println((cnt==0)?-1:(8-cnt)/2);
    }
}