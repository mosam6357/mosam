import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            int b = 0;
            String c = in.next();
            for (int j =0; j<c.length(); j++){
                if(c.charAt(j)=='('){
                    b++;
                }
                else{
                    b--;
                    if(b<0){
                        break;
                    }
                }
            }
            if(b==0){
                System.out.println("YES");
            }
            else{
                System.out.println("NO");
            }
        }
    }
}