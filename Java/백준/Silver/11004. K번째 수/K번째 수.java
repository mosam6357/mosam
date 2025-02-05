import java.util.*;
import java.io.*;

public class Main{
    public static void main(String[] args)throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String[] s = br.readLine().split(" ");
        int a = Integer.parseInt(s[0]);
        int b = Integer.parseInt(s[1]);
        ArrayList<Integer> aa = new ArrayList<Integer>(); 
        String[] ss = br.readLine().split(" ");
        for (int i=0;i<a;i++){
            aa.add(Integer.parseInt(ss[i]));
        }
        Collections.sort(aa);
        System.out.println(aa.get(b-1));
    }
}