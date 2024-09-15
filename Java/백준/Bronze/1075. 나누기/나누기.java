import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b = in.nextInt(); int c = (a/100)*100;
        while(c%b!=0){
            c+=1;
        }
        if(c%100<10){
            System.out.printf("0%d",c%100);
        }
        else{
            System.out.println(c%100);
        }
    }
}