import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[4];
        for (int i=0;i<a;i++){
            int b = in.nextInt();
            int c = in.nextInt();
            int d = in.nextInt();
            if (b==1){
                aa[3]++;
            }
            else if(c==1 || c==2){
                aa[0]++;
            }
            else if(c==3){
                aa[1]++;
            }
            else{
                aa[2]++;
            }
        }
        for (int i=0;i<4;i++){
            System.out.println(aa[i]);
        }
    }
}