import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int maxsum = 0;
        int num = 0;
        for (int i=0;i<5;i++){
            int sum =0;
            for (int j=0;j<4;j++){
                sum += in.nextInt();
            }
            if (sum>maxsum){
                num = i+1;
                maxsum = sum;
            }
        }
        System.out.printf("%d %d",num,maxsum);
    }
}