import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[2];
        for (int i=0; i<2; i++){
            a[i] = in.nextInt()+in.nextInt()*2+in.nextInt()*3;
        }
        if(a[0]==a[1]){
            System.out.println(0);
        }
        else{
            System.out.println(a[0]>a[1]?1:2);
        }
    }
}