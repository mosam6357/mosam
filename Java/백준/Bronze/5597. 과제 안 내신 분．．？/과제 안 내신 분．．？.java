import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[30];
        for(int i =0; i<28; i++){
            aa[in.nextInt()-1]++;
        }
        for(int i =0; i<30; i++){
            if(aa[i]==0){
                System.out.println(i+1);
            }
        }
    }
}