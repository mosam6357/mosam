import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[26];
        for(int i =0; i<a; i++){
            String b = in.next();
            aa[(int)b.charAt(0)-97]++;
        }
        int check=0;
        for(int i =0; i<26; i++){
            if(aa[i]>=5){
                System.out.print((char)(i+97));
                check++;
            }
        }
        if(check==0){
            System.out.print("PREDAJA");
        }
    }
}