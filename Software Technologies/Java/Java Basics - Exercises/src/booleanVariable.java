import java.util.Scanner;

public class booleanVariable {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);

        String text = scaner.nextLine();

        if ("true".equals(text.toLowerCase())) {
            System.out.println("Yes");
        }
        else if ("false".equals(text.toLowerCase())) {
            System.out.println("No");
        }
    }
}
