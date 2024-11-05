import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = (in.next().replace("a","4")).replace("e","3");
        a = (a.replace("i","1")).replace("o","0");
        System.out.println(a.replace("s","5"));
    }
}