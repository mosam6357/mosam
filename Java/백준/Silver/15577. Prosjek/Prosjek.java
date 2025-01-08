import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        float[] b = new float[a];
        for (int i=0;i<a;i++){
            b[i] = in.nextFloat();
        }
        Arrays.sort(b);
        float avg = 0;
        for (int i=0;i<a-1;i++){
            avg = (b[i]+b[i+1])/2;
            b[i+1] = avg;
        }
        System.out.println(avg);
    }
}