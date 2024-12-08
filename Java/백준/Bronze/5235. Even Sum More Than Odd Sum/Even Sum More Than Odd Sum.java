import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i =0; i<a; i++){
            int b = in.nextInt();
            int s = 0;
            for (int j=0; j<b; j++){
                int c = in.nextInt();
                if(c%2==1){
                    s+=c;
                }
                else{
                    s-=c;
                }
            }
            if(s==0){
                System.out.println("TIE");
            }
            else if(s>0){
                System.out.println("ODD");
            }
            else{
                System.out.println("EVEN");
            }
        }
    }
}