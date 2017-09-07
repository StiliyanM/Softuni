import java.util.Scanner;

public class vowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine().toLowerCase();
        char symbol = text.charAt(0);

        if (Character.isDigit(symbol)) {
            System.out.println("digit");
        }
        else if ("a".equals(text)
                || "e".equals(text)
                || "i".equals(text)
                || "o".equals(text)
                || "u".equals(text)
                || "y".equals(text)) {
            System.out.println("vowel");
        }
        else {
            System.out.println("other");
        }
    }
}
