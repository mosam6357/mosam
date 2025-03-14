import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            String s = in.nextLine();
            if(s.equals("***")){
                break;
            }
            for (int i=s.length()-1;i>=0;i--){
                System.out.printf("%c",s.charAt(i));
            }
            System.out.println();
        }
    }
}