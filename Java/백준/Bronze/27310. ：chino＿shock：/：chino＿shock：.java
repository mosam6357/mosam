import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        int count = 0;
        for (int i =0; i<a.length(); i++){
            if(a.charAt(i)=='_'){
                count++;
            }
        }
        System.out.println(a.length()+count*5+2);
    }
}