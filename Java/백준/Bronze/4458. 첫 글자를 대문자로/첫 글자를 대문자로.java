import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        in.nextLine();
        for (int i=0;i<a;i++){
            String s = in.nextLine();
            System.out.println(Character.toUpperCase(s.charAt(0))+s.substring(1));
        }
        
    }
}