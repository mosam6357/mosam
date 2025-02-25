import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        StringBuilder sb = new StringBuilder();
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int[] add = new int[a];
        int total = 0;
        for (int i=0;i<a;i++){
            total+=in.nextInt();
            add[i] = total;
        }
        for (int i=0;i<b;i++){
            int s = in.nextInt();
            int e = in.nextInt();
            if (s<2){
                sb.append(Integer.toString(add[e-1])+"\n");
            }
            else{
                sb.append(Integer.toString(add[e-1]-add[s-2])+"\n");
            }
        }
        System.out.println(sb.toString());
    }
}