import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        for (int i = 0; i < input.length(); i++) {
            char letter = input.charAt(i);
            int index = letter - 97;

            System.out.printf("%s -> %d", letter, index);
            System.out.println();
        }
    }
}
