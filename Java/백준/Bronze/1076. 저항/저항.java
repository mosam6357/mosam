import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] aa = {"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
        int sum=10*Arrays.asList(aa).indexOf(in.next())+Arrays.asList(aa).indexOf(in.next());
        System.out.print(sum);
        int a = Arrays.asList(aa).indexOf(in.next());
        if(sum!=0){
            for (int i =0; i<a; i++){
                System.out.print('0');
            }
        }
    }
}