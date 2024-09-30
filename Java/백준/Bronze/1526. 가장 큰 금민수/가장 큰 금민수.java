import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        while(true){
            int sum=0;
            String b = Integer.toString(a);
            for(int i =0; i<b.length(); i++){
                if(b.charAt(i)=='4' || b.charAt(i)=='7'){
                    sum++;
                }
            }
            if(sum==b.length()){
                System.out.println(b);
                break;
            }
            a--;
        }
    }
}