import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] aa = in.next().split("/");
        int k = Integer.parseInt(aa[0]);
        int d = Integer.parseInt(aa[1]);
        int a = Integer.parseInt(aa[2]);
        if(d==0 || k+a<d){
            System.out.println("hasu");
        }
        else{
            System.out.println("gosu");
        }
    }
}