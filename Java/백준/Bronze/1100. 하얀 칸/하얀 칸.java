import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int sum=0;
        for (int i =0; i<8; i++){
            String a = in.next();
            for(int j=0; j<4; j++){
                if(a.charAt(j*2+i%2)=='F'){
                    sum++;
                }
            }
        }
        System.out.println(sum);
    }
}