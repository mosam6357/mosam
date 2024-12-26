import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            long a[] = new long[4];
            for (int i=0; i<4; i++){
                a[i] = in.nextLong();
            }
            if(a[0]==0 && a[1]==0 && a[2]==0 && a[3]==0){
                break;
            }
            long s1 = 1; long s2 = 1; long ans=1;
            for (int i=0; i<a[1]; i++){
                s1*=a[0];
            }
            for (int i=0; i<a[2]; i++){
                s2*=s1;
            }
            for (int i=0;i<a[3];i++){
                ans*=s2;
            }
            System.out.println(ans);
        }
    }
}