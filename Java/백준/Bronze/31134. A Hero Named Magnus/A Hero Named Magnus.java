import java.util.Scanner;
import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException {
        Scanner in = new Scanner(System.in);
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        int a = in.nextInt();
        for(int i =0; i<a; i++){
            bw.write(Long.toString(in.nextLong()*2-1)+"\n");
        }
        bw.flush();
    }
}