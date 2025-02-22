import java.util.*;

public class Main{
    public static int bfs(int[][] aa,int a){
        boolean[] visited = new boolean[a+1];
        int cnt = 0;
        int s = 0;
        while (true){
            for (int i=1;i<a+1;i++){
                if (visited[i]==false){
                    s=i;
                    break;
                }
                if(i==a){
                    return cnt;
                }
            }
            Queue<int[]> q = new LinkedList<>();
            q.add(new int[] {s});
            while (!(q.isEmpty())){
                int now = q.remove()[0];
                if (visited[now] == false){
                    visited[now] = true;
                    for (int i=1;i<a+1;i++){
                        if(aa[now][i]!=0 && visited[i]==false){
                            q.add(new int[] {i});
                        }
                    }
                }
            }
            cnt+=1;
        }
    }
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int s = 0;
        int[][] aa = new int[a+1][a+1];
        for (int i=0;i<b;i++){
            int c = in.nextInt();
            int d = in.nextInt();
            aa[c][d] = 1;
            aa[d][c] = 1;
        }
        System.out.println(bfs(aa,a));
    }
}