import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        int cnt1=0;
        int cnt2=0;
        for (int i=0; i<a.length(); i++){
            if(a.charAt(i)=='A'){
                cnt1++;
            }
            else{
                cnt2++;
            }
        }
        System.out.printf("%d : %d",cnt1,cnt2);
    }
}