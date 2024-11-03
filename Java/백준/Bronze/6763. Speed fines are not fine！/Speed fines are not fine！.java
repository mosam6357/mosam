import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        if(b<=a){
            System.out.println("Congratulations, you are within the speed limit!");
        }
        else{
            int cost = 0;
            if(b-a<=20){
                cost = 100;
            }
            else if(b-a<=30){
                cost = 270;
            }
            else{
                cost = 500;
            }
            System.out.printf("You are speeding and your fine is $%d.",cost);
        }
    }
}