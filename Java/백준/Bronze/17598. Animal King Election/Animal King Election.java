import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int cnt = 0;
        String l = "Lion";
        for (int i=0; i<9; i++){
            String s = in.next();
            if(s.equals(l)){
                cnt++;
            }
        }
        System.out.println((cnt>=5)?"Lion":"Tiger");
    }
}