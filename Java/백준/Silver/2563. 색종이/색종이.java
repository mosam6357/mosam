import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt=0;
        int[][] aa = new int[100][100];
        for(int i =0; i<a; i++){
            int b = in.nextInt();
            int c = in.nextInt();
            for(int j =0; j<10; j++){
                for(int k=0; k<10; k++){
                    if(aa[b+j][c+k]==0){
                        cnt++;
                        aa[b+j][c+k]=1;
                    }
                }
            }
        }
        System.out.println(cnt);
    }
}