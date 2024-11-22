import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        int cnt1 = 0;
        int cnt2 = 0;
        for(int i=0; i<a.length(); i++){
            char b = a.charAt(i);
            if(b=='a' || b=='e' || b=='i' || b=='o'|| b=='u')cnt1++;
            else if(b=='y')cnt2++;
        }
        System.out.printf("%d %d",cnt1,cnt1+cnt2);
    }
}