import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            String s1 = in.next();
            int b = in.nextInt();
            in.nextLine();
            System.out.println(s1);
            for (int j=0;j<b;j++){
                String s = in.nextLine();
                String[] aa = s.split(" ");
                String s2 = "";
                for (int k=0;k<aa.length;k++){
                    s2+=aa[k].charAt(0);
                }
                if (s1.equals(s2)){
                    System.out.println(s);
                }
            }
        }
    }
}