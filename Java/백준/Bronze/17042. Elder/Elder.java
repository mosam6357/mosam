import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        char c = in.next().charAt(0);
        int a = in.nextInt();
        int[] q = new int[26];
        q[(int)c-65]++;
        for (int i=0;i<a;i++){
            char c1 = in.next().charAt(0);
            char c2 = in.next().charAt(0);
            if(c2==c){
                c = c1;
                q[(int)c-65]=1;
            }
        }
        System.out.println(c);
        System.out.println(Arrays.stream(q).sum());
    }
}