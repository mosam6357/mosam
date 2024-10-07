import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String b = in.next();
        int up=0; int rt=0;
        for (int i =0; i<a; i++){
            char c = b.charAt(i);
            if(c=='N'){
                up++;
            }
            else if(c=='S'){
                up--;
            }
            else if(c=='E'){
                rt++;
            }
            else{
                rt--;
            }
        }
        up = up>0?up:-up;
        rt = rt>0?rt:-rt;
        System.out.println(up+rt);
    }
}