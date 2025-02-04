import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt = 0;
        for (int i=1;i<=a;i++){
            if(i<=99){
                cnt++;
            }
            else{
                String s = Integer.toString(i);
                int ck = 0;
                int x = 0;
                for (int j=0;j<s.length()-1;j++){
                    int t = s.charAt(j+1)-s.charAt(j);
                    if (j==0){
                        x = t;
                    }
                    else{
                        if(t!=x){
                            ck=1;
                            break;
                        }
                    }
                }
                if (ck==0){
                    cnt++;
                }
            }
        }
        System.out.println(cnt);
    }
}