import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[4];
        for (int i=0; i<4; i++){
            a[i] = in.nextInt();
        }
        if(a[0]==a[1] && a[1]==a[2] && a[2]==a[3]){
            System.out.println("Fish At Constant Depth");
        }
        else if(a[0]<a[1] && a[1]<a[2] && a[2]<a[3]){
            System.out.println("Fish Rising");
        }
        else if(a[0]>a[1] && a[1]>a[2] && a[2]>a[3]){
            System.out.println("Fish Diving");
        }
        else{
            System.out.println("No Fish");
        }
    }
}