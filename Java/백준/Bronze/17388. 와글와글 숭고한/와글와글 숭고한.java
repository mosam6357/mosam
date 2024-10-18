import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[3];
        for (int i=0; i<3; i++){
            a[i] = in.nextInt();
        }
        if(a[0]+a[1]+a[2]<100){
            int min = a[0]<a[1]?a[0]:a[1];
            min = min<a[2]?min:a[2];
            if(min==a[0]){
                System.out.println("Soongsil");
            }
            else if(min==a[1]){
                System.out.println("Korea");
            }
            else{
                System.out.println("Hanyang");
            }
        }
        else{
            System.out.println("OK");
        }
    }
}