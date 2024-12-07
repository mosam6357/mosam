import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        int s = 0;
        for (int i =0; i<3; i++){
            s +=in.nextInt();
        }
        if(s<t && t>240){
            System.out.println("flight");
        }
        else{
            System.out.println("high speed rail");
        }
    }
}