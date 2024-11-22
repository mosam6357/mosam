import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] a = new String[5];
        for (int i =0; i<5; i++){
            a[i] = in.next();
        }
        if(Integer.parseInt(a[0])+Integer.parseInt(a[2])==Integer.parseInt(a[4])){
            System.out.println("YES");
        }
        else{
            System.out.println("NO");
        }
    }
}