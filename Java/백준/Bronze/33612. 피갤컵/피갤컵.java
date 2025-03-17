import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if(a == 1){
            System.out.println("2024 8");
        }
        else if(a==2){
            System.out.println("2025 3");
        }
        else if(a==3){
            System.out.println("2025 10");
        }
        else if(a==4){
            System.out.println("2026 5");
        }
        else{
            System.out.println("2026 12");
        }
    }
}