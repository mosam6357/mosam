import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String n = in.next();
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            String a = in.next();
            int cnt1 = 0;
            int cnt2 = 0;
            for (int j=0;j<4;j++){
                for (int k=0;k<4;k++){
                    if(a.charAt(j)==n.charAt(k)){
                        cnt1++;
                        break;
                    }
                }
                if (a.charAt(j)==n.charAt(j)){
                    cnt2++;
                }
            }
            System.out.printf("%d %d\n",cnt1,cnt2);
        }
    }
}