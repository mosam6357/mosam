import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String q = in.next();
        if(q.length()>1){
            System.out.println("Love is open door");
        }
        else{
            int w = Integer.parseInt(q);
            if(w>=6){
                System.out.println("Love is open door");
            }
            else{
                int e = in.nextInt();
                if(e==0){
                    for (int i=0; i<w-1;i++){
                        System.out.println(1-i%2);
                    }
                }
                else{
                    for (int i =0; i<w-1; i++){
                        System.out.println(i%2);
                    }
                }
            }
        }
    }
}