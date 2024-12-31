import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        String s = in.next();
        int f = 0;
        int p = 1;
        for (int i=0;i<a;i++){
            if(s.charAt(i)=='L'){
                if(p==0){
                    f++;
                }
                p=0;
            }
            else{
                if(p==1){
                    f++;
                }
                p=1;
            }
        }
        System.out.println((f>b)?0:b-f);
    }
}