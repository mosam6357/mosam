import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String b = in.next();
        int ck=0;
        for (int i =1; i<a; i++){
            if(b.charAt(0)!=b.charAt(i)){
                ck=1;
            }
        }
        if(ck==0){
            System.out.println("Yes");
        }
        else{
            System.out.println("No");
        }
    }
}