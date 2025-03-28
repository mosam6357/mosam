import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int l = 0;
        int n = 0;
        for (int i=0;i<a;i++){
            int cnt = 0;
            String s = in.next();
            for (int j=0;j<b;j++){
                if (s.charAt(j)=='1' && (j==0 || s.charAt(j-1)=='0')){
                    cnt++;
                }
            }
            if (cnt>l){
                n=1;
                l=cnt;
            }
            else if(cnt==l){
                n++;
            }
        }
        System.out.printf("%d %d",l,n);
    }
}