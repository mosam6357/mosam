import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] b = new int[a];
        int max = 1;
        for (int i=0; i<a; i++){
            b[i] = in.nextInt();
            max = max>=b[i]?max:b[i];
        }
        int[] z = new int[max+2]; z[0] = 1; z[1] = 0;
        int[] o = new int[max+2]; o[0] = 0; o[1] = 1;
        for (int i=2; i<max+1; i++){
            z[i] = z[i-1]+z[i-2];
            o[i] = o[i-1]+o[i-2];
        }
        for (int i=0; i<a; i++){
            System.out.printf("%d %d\n",z[b[i]],o[b[i]]);
        }
    }
}