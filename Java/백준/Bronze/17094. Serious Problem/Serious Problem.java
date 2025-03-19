import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String s = in.next();
        int cnt = 0;
        for (int i=0;i<a;i++){
            if (s.charAt(i)=='2'){
                cnt++;
            }
            else{
                cnt--;
            }
        }
        if (cnt>0){
            System.out.println("2");
        }
        else if (cnt==0){
            System.out.println("yee");
        }
        else{
            System.out.println("e");
        }
    }
}