import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int cnt = 0;
        String[] s = new String[a];
        for (int i=0;i<a;i++){
            s[i] = in.next();
        }
        for (int i=0;i<a;i++){
            for (int j=0;j<b-1;j++){
                if(s[i].charAt(j)==s[i].charAt(j+1) && s[i].charAt(j)=='.'){
                    cnt++;
                }
            }
        }
        for (int i=0;i<b;i++){
            for (int j=0;j<a-1;j++){
                if (s[j].charAt(i)==s[j+1].charAt(i) && s[j].charAt(i)=='.'){
                    cnt++;
                }
            }
        }
        System.out.println(cnt);
    }
}