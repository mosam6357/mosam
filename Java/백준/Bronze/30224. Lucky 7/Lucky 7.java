import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next(); int b = Integer.parseInt(a);
        int c1 = 0; int c2=0;
        if(b%7==0){
            c1++;
        }
        for (int i =0; i<a.length(); i++){
            if(a.charAt(i)=='7'){
                c2++;
                break;
            }
        }
        if(c1+c2==0){
            System.out.println(0);
        }
        else if(c1==1 && c2==0){
            System.out.println(1);
        }
        else if(c1==0 && c2==1){
            System.out.println(2);
        }
        else{
            System.out.println(3);
        }
    }
}