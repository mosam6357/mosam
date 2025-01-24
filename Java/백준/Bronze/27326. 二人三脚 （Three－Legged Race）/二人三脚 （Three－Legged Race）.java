import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<2*a-1;i++){
            aa[in.nextInt()-1]++;
        }
        for(int i=0;i<a;i++){
            if(aa[i]==1){
                System.out.println(i+1);
                break;
            }
        }
    }
}