import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.OutputStreamWriter;
import java.io.InputStreamReader;
import java.io.IOException;

public class Main{
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        int a = Integer.parseInt(br.readLine());
        for(int i =0; i<a; i++){
            String[] aa = br.readLine().split(" ");
            int b = Integer.parseInt(aa[0]);
            int c = Integer.parseInt(aa[1]);
            int d = b+c;
            bw.write(d+"\n");
        }
        bw.flush();
    }
}