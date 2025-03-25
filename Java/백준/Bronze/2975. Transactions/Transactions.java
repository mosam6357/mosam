import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            int a = in.nextInt();
            String s = in.next();
            int b = in.nextInt();
            if (a==0 && s.charAt(0)=='W' && b==0){
                break;
            }
            if (s.charAt(0)=='W'){
                if (a-b<-200){
                    System.out.println("Not allowed");
                }
                else{
                    System.out.println(a-b);
                }
            }
            else{
                System.out.println(a+b);
            }
        }
    }
}