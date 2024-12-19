import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        float a = in.nextFloat();
        float b = in.nextFloat();
        float bmi = a/(b*b);
        if(bmi<18.5){
            System.out.println("Underweight");
        }
        else if(bmi>25){
            System.out.println("Overweight");
        }
        else{
            System.out.println("Normal weight");
        }
    }
}