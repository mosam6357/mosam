import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        for (int i =0; i<8;i++){
            if(in.nextInt()==9){
                System.out.println('F');
                break;
            }
            if(i==7){
                System.out.println('S');
            }
        }
    }
}