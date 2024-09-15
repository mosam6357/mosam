import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int i =64; int cnt=0;
        while(a!=0){
            if(a>=i){
                a-=i;
                cnt++;
            }
            else{
                i/=2;
            }
        }
        System.out.println(cnt);
    }
}