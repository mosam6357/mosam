import java.util.Scanner;

public class Main{
    public static int dsum(String a){
        int sum = 0;
        for(int i=0; i<a.length(); i++){
            sum += Integer.parseInt(Character.toString(a.charAt(i)));
        }
        if(sum>=10){
            return dsum(Integer.toString(sum));
        }
        else{
            return sum;
        }
    }
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            String a = in.next();
            if(a.charAt(0)=='0'){
                break;
            }
            System.out.println(dsum(a));
        }
    }
}