import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if(a<=6){
            int[] q = {0,0,1,1,1,3,2};
            System.out.println(q[a]);
        }
        else{
            int[] aa = new int[a+1];
            aa[0]=0;aa[1]=0;aa[2]=1;aa[3]=1;aa[4]=1;aa[5]=3;aa[6]=2;
            for(int i=2; i<a+1; i++){
                int min = aa[i-1]+1;
                if(i%2==0){
                    min = (min<aa[i/2]+1)?min:aa[i/2]+1;
                }
                if(i%3==0){
                    min = (min<aa[i/3]+1)?min:aa[i/3]+1;
                }
                aa[i] = min;
            }
            System.out.println(aa[a]);
        }
    }
}