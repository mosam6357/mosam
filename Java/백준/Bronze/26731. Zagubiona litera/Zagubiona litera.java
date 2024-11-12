import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[26];
        String a  = in.next();
        for (int i=0; i<25; i++){
            aa[(int)a.charAt(i)-65]++;
        }
        for (int i =0;i<26;i++){
            if(aa[i]==0){
                System.out.println((char)(i+65));
                break;
            }
        }
    }
}