import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            String s = in.next();
            if(s.charAt(s.length()/2-1)==s.charAt(s.length()/2)){
                System.out.println("Do-it");
            }
            else{
                System.out.println("Do-it-Not");
            }
        }
    }
}