import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int sum=0;
        for(int i =0; i<a; i++){
            int b = in.nextInt();
            if(b%2==0){
                sum++;
            }
            else{
                sum--;
            }
        }
        if(sum>0){
            System.out.println("Happy");
        }
        else{
            System.out.println("Sad");
        }
    }
}