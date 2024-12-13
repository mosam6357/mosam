import java.util.Scanner;
import java.util.HashMap;
import java.util.Map;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        HashMap<String, String> map = new HashMap<String,String>();
        for (int i=0; i<a; i++){
            map.put(in.next(),in.next());
        }
        for (int i=0; i<b; i++){
            System.out.printf("%s\n",map.get(in.next()));
        }
    }
}