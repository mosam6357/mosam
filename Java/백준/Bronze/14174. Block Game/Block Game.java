import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int[] aa = new int[26];
        for(int i =0; i<a; i++){
            String b = in.next(); String c = in.next();
            for (int j =0; j<26; j++){
                int count1 = 0; int count2 = 0;
                for(int k =0; k<b.length(); k++){
                    if(b.charAt(k)==(char)(j+97)){
                        count1++;
                    }
                }
                for(int k =0; k<c.length(); k++){
                    if(c.charAt(k)==(char)(j+97)){
                        count2++;
                    }
                }
                aa[j]+=count1>count2?count1:count2;
            }
        }
        for(int i=0; i<26; i++){
            System.out.println(aa[i]);
        }
    }
}