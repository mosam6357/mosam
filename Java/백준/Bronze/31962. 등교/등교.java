import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int max = 0;
        for (int i =0; i<a; i++){
            int c = in.nextInt();
            int d = in.nextInt();
            if(c+d<=b){
                max = c>max?c:max;
            }
        }
        System.out.println(max==0?-1:max);
    }
}