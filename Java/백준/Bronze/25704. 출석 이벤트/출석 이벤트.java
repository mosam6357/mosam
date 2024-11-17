import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int min = b;
        if(a>=5){
            min-=500;
        }
        if(a>=10){
            min = min<b-b/10?min:b-b/10;
        }
        if(a>=15){
            min = min<b-2000?min:b-2000;
        }
        if(a>=20){
            min = min<b-b/4?min:b-b/4;
        }
        System.out.println(min>0?min:0);
    }
}