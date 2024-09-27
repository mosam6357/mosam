import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int i=666; int cnt=0;
        while(true){
            String b = Integer.toString(i);
            if(b.contains("666")){
                cnt++;
                if(cnt==a){
                    System.out.println(b);
                    break;
                }
            }
            i++;
        }
    }
}