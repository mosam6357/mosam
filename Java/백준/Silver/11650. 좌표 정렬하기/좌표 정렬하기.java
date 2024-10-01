import java.util.*;
import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException {
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        int[][] aa = new int[a][2];
        for (int i =0; i<a; i++){
            aa[i][0] = in.nextInt();
            aa[i][1] = in.nextInt();
        }
        Arrays.sort(aa,new Comparator<int[]>(){
            @Override
            public int compare(int[] x, int[] y){
                if(x[0] == y[0]){
                    return x[1]-y[1];
                }
                else{
                    return x[0]-y[0];
                }
            }
        });
        
        for (int i =0; i<a; i++){
            bw.write(aa[i][0]+" "+aa[i][1]+"\n");
        }
        bw.flush();
        bw.close();
    }
}