import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] aa = in.nextLine().split(" ");
        int total = 0;
        for (int i=0;i<aa.length;i++){
            total+=Integer.parseInt(aa[i]);
        }
        System.out.println(total);
    }
}