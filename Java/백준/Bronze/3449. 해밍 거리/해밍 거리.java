import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            String s1 = in.next();
            String s2 = in.next();
            int cnt = 0;
            for (int j=0;j<s1.length();j++){
                if(s1.charAt(j)!=s2.charAt(j)){
                    cnt++;
                }
            }
            System.out.printf("Hamming distance is %d.\n",cnt);
        }
    }
}