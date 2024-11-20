import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt()+in.nextInt();
        if(a>12){
            if(a%12==0){
                System.out.println(12);
            }
            else{
                System.out.println(a%12);
            }
        }
        else{
            System.out.println(a);
        }
    }
}