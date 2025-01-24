import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int p = in.nextInt();
        int a = in.nextInt();
        int s = 0;
        for (int i=0;i<a;i++){
            s+=(in.nextInt()+1)/2;
        }
        if(s>=p){
            System.out.println("YES");
        }
        else{
            System.out.println("NO");
        }
    }
}