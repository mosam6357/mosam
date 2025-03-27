import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int sum = 0;
        int cnt = 0;
        for (int i=0;i<a;i++){
            int n = in.nextInt();
            if (n==0){
                cnt++;
            }
            sum+=n;
        }
        if (cnt*2>=a){
            System.out.println("INVALID");
        }
        else if(sum>0){
            System.out.println("APPROVED");
        }
        else{
            System.out.println("REJECTED");
        }
    }
}