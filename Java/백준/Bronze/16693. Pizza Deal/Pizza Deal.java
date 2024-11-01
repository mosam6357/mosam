import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        double[] a = new double[4];
        for (int i=0; i<4; i++){
            a[i] = in.nextDouble();
        }
        double c1 = a[0]/a[1];
        double c2 = (a[2]*a[2]*Math.PI)/a[3];
        if(c1>c2){
            System.out.println("Slice of pizza");
        }
        else{
            System.out.println("Whole pizza");
        }
    }
}