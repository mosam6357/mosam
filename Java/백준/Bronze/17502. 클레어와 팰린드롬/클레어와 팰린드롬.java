import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String b = in.next();
        String c = "";
        for (int i =0; i<a; i++){
            c+=b.charAt(b.length()-1-i);
        }
        for (int i = 0; i<a; i++){
            if(b.charAt(i)=='?'){
                if(c.charAt(i)=='?'){
                    System.out.printf("a");
                }
                else{
                    System.out.printf("%c",c.charAt(i));
                }
            }
            else{
                System.out.printf("%c",b.charAt(i));
            }
        }
    }
}