import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in); int i=0;
        while(true){
            String a = in.nextLine();
            if(a.equals("0")){
                break;
            }
            else{
                System.out.printf("Case %d: Sorting... done!%n",i+1);
            }
            i+=1;
        }
    }
}