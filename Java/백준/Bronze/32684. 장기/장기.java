import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);double s1 = in.nextInt()*13+in.nextInt()*7+in.nextInt()*5+in.nextInt()*3+in.nextInt()*3+in.nextInt()*2;
        double s2 = in.nextInt()*13+in.nextInt()*7+in.nextInt()*5+in.nextInt()*3+in.nextInt()*3+in.nextInt()*2+1.5;
        if(s1>s2){
            System.out.println("cocjr0208");
        }
        else{
            System.out.println("ekwoo");
        }
    }
}