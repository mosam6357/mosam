import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for(int i=0; i<a; i++){
            System.out.printf("String #%d%n",i+1);
            String b = in.next(); String c = "";
            for(int j =0; j<b.length();j++){
                int d = (int)b.charAt(j)+1;
                if(d==91){
                    c+='A';
                }
                else{
                    c+=(char)((int)b.charAt(j)+1);
                }
            }
            System.out.println(c);
            if(i!=a-1){
                System.out.println();
            }
        }
    }
}