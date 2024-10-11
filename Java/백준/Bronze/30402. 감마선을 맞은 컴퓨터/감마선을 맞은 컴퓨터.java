import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        for (int i =0; i<15; i++){
            String a = in.nextLine();
            boolean b1 = a.contains("w");
            boolean b2 = a.contains("b");
            boolean b3 = a.contains("g");
            if(b1){
                System.out.println("chunbae");
                break;
            }
            if(b2){
                System.out.println("nabi");
                break;
            }
            if(b3){
                System.out.println("yeongcheol");
                break;
            }
        }
    }
}