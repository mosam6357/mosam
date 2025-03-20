import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        StringBuilder sb = new StringBuilder();
        for (int i=0;i<5;i++){
            for (int j=0;j<a;j++){
                int n = 0;
                if (i==0 || i==4){
                    n = a*5;
                }
                else{
                    n = a;
                }
                for (int k=0;k<n;k++){
                    sb.append("@");
                }
                sb.append("\n");
            }
        }
        System.out.println(sb.toString());
    }
}