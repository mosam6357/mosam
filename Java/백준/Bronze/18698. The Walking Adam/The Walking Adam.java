import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            String b = in.next();
            int walk = 0;
            for (int j = 0; j<b.length(); j++){
                if(b.charAt(j)=='U'){
                    walk++;
                }
                else{
                    break;
                }
            }
            System.out.println(walk);
        }
    }
}