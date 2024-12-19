import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            int a = in.nextInt();
            if(a==0){
                break;
            }
            for (int i=0; i<a; i++){
                String s = "";
                for (int j=0; j<i+1; j++){
                    s+="*";
                }
                System.out.println(s);
            }
        }
    }
}