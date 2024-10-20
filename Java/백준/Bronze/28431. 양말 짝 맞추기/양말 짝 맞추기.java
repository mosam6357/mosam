import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[10];
        for (int i=0; i<5; i++){
            int a = in.nextInt();
            if(aa[a]==0){
                aa[a]++;
            }
            else{
                aa[a]--;
            }
        }
        for (int i =0; i<10; i++){
            if(aa[i]==1){
                System.out.println(i);
                break;
            }
        }
    }
}