import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] aa = in.nextLine().split("-");
        for (int i=0;i<aa.length;i++){
            System.out.printf("%c",aa[i].charAt(0));
        }
    }
}