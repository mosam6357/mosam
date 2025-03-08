import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int m1 = 0; int m2 = 0; int total = 0;
        for (int i=0;i<3;i++){
            int n = in.nextInt();
            total+=n;
            m1 = m1>n?m1:n;
        }
        for (int i=0;i<3;i++){
            int n = in.nextInt();
            total+=n;
            m2 = m2>n?m2:n;
        }
        int minm = m1<m2?m1:m2;
        System.out.println(total-minm*2);
    }
}