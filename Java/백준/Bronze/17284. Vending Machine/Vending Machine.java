import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int money = 5000;
        String[] aa = in.nextLine().split(" ");
        for (int i=0;i<aa.length;i++){
            if (aa[i].equals("1")){
                money-=500;
            }
            else if(aa[i].equals("2")){
                money-=800;
            }
            else{
                money-=1000;
            }
        }
        System.out.println(money);
    }
}