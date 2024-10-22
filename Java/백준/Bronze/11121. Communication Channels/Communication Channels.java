import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for (int i =0; i<q; i++){
            String a = in.next();
            String b = in.next();
            if(a.equals(b)){
                System.out.println("OK");
            }
            else{
                System.out.println("ERROR");
            }
        }
    }
}