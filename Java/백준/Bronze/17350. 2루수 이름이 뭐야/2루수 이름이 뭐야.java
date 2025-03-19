import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            String s = in.next();
            if (s.equals("anj")){
                System.out.println("뭐야;");
                break;
            }
            if (i==a-1){
                System.out.println("뭐야?");
            }
        }
    }
}