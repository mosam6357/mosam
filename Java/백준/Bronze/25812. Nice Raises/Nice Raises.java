import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int cnt1 = 0;
        int cnt2 = 0;
        for (int i=0;i<a;i++){
            int c = in.nextInt();
            if(b>c){
                cnt1++;
            }
            else if(c>b){
                cnt2++;
            }
        }
        if(cnt1>cnt2){System.out.println(1);}
        else if(cnt2>cnt1){System.out.println(2);}
        else{System.out.println(0);}
    }
}