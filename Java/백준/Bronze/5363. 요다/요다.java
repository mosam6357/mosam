import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        in.nextLine();
        for (int i =0; i<a; i++){
            String[] aa = in.nextLine().split(" ");
            for(int j=2; j<aa.length; j++){
                System.out.printf("%s ",aa[j]);
            }
            System.out.printf("%s %s\n",aa[0],aa[1]);
        }
    }
}