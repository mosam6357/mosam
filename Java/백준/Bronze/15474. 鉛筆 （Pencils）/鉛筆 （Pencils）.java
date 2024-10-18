import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[5];
        for (int i =0; i<5; i++){
            aa[i] = in.nextInt();
        }
        int c1 =aa[0]%aa[1]==0?aa[0]/aa[1]*aa[2]:(aa[0]/aa[1]+1)*aa[2];
        int c2 =aa[0]%aa[3]==0?aa[0]/aa[3]*aa[4]:(aa[0]/aa[3]+1)*aa[4];
        System.out.println(c1<c2?c1:c2);
    }
}