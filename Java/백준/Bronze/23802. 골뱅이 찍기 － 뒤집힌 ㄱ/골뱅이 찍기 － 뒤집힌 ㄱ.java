import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<5;i++){
            for (int j=0;j<a;j++){
                if (i==0){
                    for (int k=0;k<a*5;k++){
                        System.out.printf("@");
                    }
                }
                else{
                    for (int k=0;k<a;k++){
                        System.out.printf("@");
                    }
                }
                System.out.println();
            }
        }
    }
}