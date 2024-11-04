import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        in.nextLine();
        for (int i=0; i<3; i++){
            String[] aa = in.nextLine().split(" ");
            if(!(Arrays.asList(aa).contains("7"))){
                System.out.println(0);
                break;
            }
            if(i==2){
                System.out.println(777);
            }
        }
    }
}