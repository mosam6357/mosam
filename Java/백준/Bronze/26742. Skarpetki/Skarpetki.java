import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        int b = 0;
        int w = 0;
        for (int i =0; i<a.length(); i++){
            if(a.charAt(i)=='B'){
                b++;
            }
            else{
                w++;
            }
        }
        System.out.println(b/2+w/2);
    }
}