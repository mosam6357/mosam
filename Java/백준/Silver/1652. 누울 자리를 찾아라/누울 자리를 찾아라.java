import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int ck=0;
        int cnt1=0;
        int cnt2=0;
        String[] b = new String[a];
        for (int i=0; i<a; i++){
            b[i] = in.next();
            ck=0;
            for(int j =0; j<a-1; j++){
                if(b[i].charAt(j)==b[i].charAt(j+1) && b[i].charAt(j) == '.' && ck==0){
                    cnt1++;
                    ck++;
                }
                else if(b[i].charAt(j) == 'X'){
                    ck=0;
                }
            }
        }
        for(int i=0; i<a; i++){
            ck=0;
            for (int j=0; j<a-1; j++){
                if(b[j].charAt(i) == b[j+1].charAt(i) && b[j].charAt(i) == '.' && ck==0){
                    cnt2++;
                    ck++;
                }
                else if(b[j].charAt(i) == 'X'){
                    ck=0;
                }
            }
        }
        System.out.printf("%d %d",cnt1,cnt2);
    }
}