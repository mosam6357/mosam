import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int m = in.nextInt();
        int[] a = new int[3];
        for (int i=0;i<3;i++){
            a[i] = in.nextInt();
        }
        if(a[0]<=m){
            System.out.println("Watermelon");
        }
        else if(a[1]<=m){
            System.out.println("Pomegranates");
        }
        else if(a[2]<=m){
            System.out.println("Nuts");
        }
        else{
            System.out.println("Nothing");
        }
    }
}