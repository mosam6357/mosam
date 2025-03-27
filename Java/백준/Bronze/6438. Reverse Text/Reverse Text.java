import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        in.nextLine();
        for (int i=0;i<a;i++){
            String s = in.nextLine();
            for (int j=s.length()-1;j>=0;j--){
                System.out.printf("%c",s.charAt(j));
            }
            System.out.println();
        }
    }
}