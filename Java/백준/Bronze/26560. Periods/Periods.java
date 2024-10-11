import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        in.nextLine();
        for(int i =0; i<a; i++){
            String b = in.nextLine();
            if(b.charAt(b.length()-1)=='.'){
                System.out.println(b);
            }
            else{
                System.out.println(b+".");
            }
        }
        
    }
}