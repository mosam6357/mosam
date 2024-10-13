import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] b = new int[a];
        for (int i =0; i<a; i++){
            b[i] = in.nextInt();
        }
        Arrays.sort(b);
        for (int i =0; i<a; i++){
            b[i]+=b.length-i+1;
        }
        Arrays.sort(b);
        System.out.println(b[b.length-1]);
    }
}