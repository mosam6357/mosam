import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[6];
        for (int i=0; i<6; i++){
            aa[i]=in.nextInt();
        }
        if(aa[0]==aa[3] && aa[1]==aa[4] && aa[2]==aa[5]){
            System.out.println("A");
        }
        else if(aa[1]==aa[4] && aa[2]==aa[5]){
            if(aa[3]>=(aa[0]+1)/2){
                System.out.println("B");
            }
            else{
                System.out.println("C");
            }
        }
        else{
            if(aa[4]>=(aa[1]+1)/2){
                System.out.println("D");
            }
            else{
                System.out.println("E");
            }
        }
    }
}