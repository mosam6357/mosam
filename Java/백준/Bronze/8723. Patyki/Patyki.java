import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[3];
        for (int i=0; i<3; i++){
            a[i] = in.nextInt();
        }
        int[] b = {a[0]*a[0],a[1]*a[1],a[2]*a[2]};
        if(a[0]==a[1] && a[1]==a[2]){
            System.out.println(2);
        }
        else if(b[0]==b[1]+b[2] || b[1]==b[0]+b[2] || b[2]==b[0]+b[1]){
            System.out.println(1);
        }
        else{
            System.out.println(0);
        }
    }
}