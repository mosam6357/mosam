import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int x = in.nextInt();
        String a = in.next();
        String s = "";
        for (int i=0;i<x;i++){
            char c = a.charAt(i);
            if(c=='I'){
                s+='J';
            }
            else if(c=='O'){
                s+='I';
            }
            else{
                s+='O';
            }
        }
        System.out.println(s);
    }
}