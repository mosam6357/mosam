import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int sum=0;
        for(int i=0; i<a; i++){
            sum+=in.nextInt();
        }
        if(sum==0){
            System.out.println("Stay");
        }
        else if(sum>0){
            System.out.println("Right");
        }
        else{
            System.out.println("Left");
        }
    }
}