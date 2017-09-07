import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();

        if (text.length() > 20) {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 20; i++) {
                result.append(text.charAt(i));
            }
            System.out.println(result);
        }
        else if (text.length() < 20) {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.length(); i++) {
                result.append(text.charAt(i));
            }
            for (int i = 0; i < 20 - text.length(); i++) {
                result.append("*");
            }
            System.out.println(result);
        }
        else {
            System.out.println(text);
        }
    }
}
