import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        while(true){
            String s = in.next();
            if (s.equals("=")){
                break;
            }
            else{
                int n = in.nextInt();
                if (s.equals("+")){
                    a+=n;
                }
                else if(s.equals("-")){
                    a-=n;
                }
                else if(s.equals("*")){
                    a*=n;
                }
                else{
                    a/=n;
                }
            }
        }
        System.out.println(a);
    }
}