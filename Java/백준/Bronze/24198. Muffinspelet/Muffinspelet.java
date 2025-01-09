import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int i = 1;
        int[] aa = {0,0};
        while (a>0){
            int k=i%2;
            if(a%2==0){
                aa[k]+=a/2;
                a-=a/2;
            }
            else{
                aa[k]+=a/2+1;
                a-=a/2+1;
            }
            i++;
        }
        System.out.printf("%d %d",aa[0],aa[1]);
    }
}