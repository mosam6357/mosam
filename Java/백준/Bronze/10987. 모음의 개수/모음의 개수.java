import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a =  in.next();
        String b =  "aeiou";
        int cnt = 0;
        for (int i =0; i<a.length(); i++){
            for (int j =0; j<5; j++){
                if(a.charAt(i)==b.charAt(j)){
                    cnt++;
                    break;
                }
            }
        }
        System.out.println(cnt);
    }
}