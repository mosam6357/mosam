import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException {
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int[] aa = new int[10000];
        int a = Integer.parseInt(br.readLine());
        for (int i=0;i<a;i++){
            aa[Integer.parseInt(br.readLine())-1]++;
        }
        for (int i=0;i<10000;i++){
            for (int j =0;j<aa[i];j++){
                bw.write(Integer.toString(i+1)+"\n");
            }
        }
        bw.flush();
        bw.close();
    }
}