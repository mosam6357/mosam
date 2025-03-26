import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int c = 0;
        int cm = 0;
        for (int i=0;i<a;i++){
            int n = in.nextInt();
            if (n==0){
                cm = cm>c?cm:c;
                c=0;
            }
            else{
                c++;
            }
        }
        cm = cm>c?cm:c;
        System.out.println(cm);
    }
}