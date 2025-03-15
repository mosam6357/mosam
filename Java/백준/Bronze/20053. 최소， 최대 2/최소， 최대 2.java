import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int a = in.nextInt();
            int max = -1000001;
            int min = 1000001;
            for (int j=0;j<a;j++){
                int n = in.nextInt();
                max = max>n?max:n;
                min = min<n?min:n;
            }
            System.out.printf("%d %d\n",min,max);
        }
    }
}