import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = {1,3,6,8,2,5};
        int ck = 0;
        for (int i=0; i<3; i++){
            int a = in.nextInt();
            if(a!=aa[i*2] && a!=aa[i*2+1]){
                ck=1;
                break;
            }
        }
        System.out.println((ck==0)?"JAH":"EI");
    }
}