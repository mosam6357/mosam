import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in= new Scanner(System.in);
        int a = in.nextInt(); int y=0; int m=0;
        for(int i =0; i<a; i++){
            int q = in.nextInt();
            y+=(q/30+1)*10;
            m+=(q/60+1)*15;
        }
        if(y==m){
            System.out.printf("Y M %d",y);
        }
        else if(y<m){
            System.out.printf("Y %d",y);
        }
        else{
            System.out.printf("M %d",m);
        }
    }
}