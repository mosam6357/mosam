import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for(int i=0;i<a;i++){
            int b = in.nextInt();
            if(b<=3){
                int[] aa = {0,1,2,4};
                System.out.println(aa[b]);
            }
            else{
                int[] aa = new int[b+1];
                aa[0]=0;aa[1]=1;aa[2]=2;aa[3]=4;
                for(int j=4;j<b+1;j++){
                    aa[j]=aa[j-1]+aa[j-2]+aa[j-3];
                }
                System.out.println(aa[b]);
            }
        }
    }
}