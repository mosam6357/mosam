import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] aa = new String[3];
        int a =0;
        for(int i=0; i<3; i++){
            aa[i] = in.next();
            if(aa[i].charAt(0)!='F' && aa[i].charAt(0)!='B'){
                a = Integer.parseInt(aa[i])+3-i;
            }
        }
        if(a%3==0){
            System.out.printf("Fizz");
        }
        if(a%5==0){
            System.out.printf("Buzz");
        }
        if(a%3!=0 && a%5!=0){
            System.out.println(a);
        }
    }
}