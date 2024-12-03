import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            int max = 0;
            for (int j=0; j<5; j++){
                int b = in.nextInt();
                max = max>b?max:b;
            }
            System.out.printf("Case #%d: %d\n",i+1,max);
        }
    }
}