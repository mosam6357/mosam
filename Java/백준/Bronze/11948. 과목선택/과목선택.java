import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[4];
        int[] bb = new int[2];
        for(int i =0; i<6; i++){
            if(i<4){
                aa[i] = in.nextInt();
            }
            else{
                bb[i-4] = in.nextInt();
            }
        }
        int min1 = 100;
        for (int i =0; i<4; i++){
            if(aa[i]<min1){
                min1 = aa[i];
            }
        }
        int min2 = bb[0]<bb[1]?bb[0]:bb[1];
        System.out.println(aa[0]+aa[1]+aa[2]+aa[3]+bb[0]+bb[1]-(min1+min2));
    }         
}