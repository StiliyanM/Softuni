import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String inputLine = scanner.nextLine();

        StringBuilder result = new StringBuilder(100);

        for (int i = inputLine.length() - 1; i >= 0; i--) {
            result.append(inputLine.charAt(i));
        }

        System.out.println(result);
    }
}
