import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for (int i= 0; i<q; i++){
        Long a = in.nextLong();
        Long b = in.nextLong();
        Long c = in.nextLong();
        Long d = in.nextLong();
        if(a*b>c*d){
            System.out.println("TelecomParisTech");
        }
        else if(a*b==c*d){
            System.out.println("Tie");
        }
        else{
            System.out.println("Eurecom");
        }
        }
    }
}