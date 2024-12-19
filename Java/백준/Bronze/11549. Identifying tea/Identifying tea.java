import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt= 0;
        for (int i=0; i<5; i++){
            if(in.nextInt()==a){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}