import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int[] aa = new int[a];
        int[] bb = new int[a];
        for (int i=0; i<a; i++){
            aa[i] = in.nextInt();
            bb[i] = in.nextInt();
        }
        String s = in.next();
        int x=0,y=0;
        for (int i=0; i<b; i++){
            char c = s.charAt(i);
            int f1=x,f2=y;
            if(c=='L'){f1--;}
            if(c=='R'){f1++;}
            if(c=='U'){f2++;}
            if(c=='D'){f2--;}
            for (int j=0; j<a; j++){
                if(f1==aa[j] && f2==bb[j]){break;}
                if(j==a-1){x=f1;y=f2;}
            }
        }
        System.out.printf("%d %d",x,y);
    }
}