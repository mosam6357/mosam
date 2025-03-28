import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt = 0;
        for (int i=0;i<a;i++){
            if(in.nextInt()%2==1){
                cnt++;
            }
            else{
                cnt--;
            }
        }
        if (a%2==cnt){
            System.out.println(1);
        }
        else{
            System.out.println(0);
        }
    }
}