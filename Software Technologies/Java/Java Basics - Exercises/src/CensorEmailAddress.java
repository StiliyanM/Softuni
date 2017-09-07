import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String emailInput = scanner.nextLine();
        String[] email = emailInput.split("@");
        String text = scanner.nextLine();

        String userName = email[0];
        StringBuilder replacement = new StringBuilder();
        for (int i = 0; i < userName.length(); i++) {
            replacement.append("*");
        }
        replacement.append("@");
        replacement.append(email[1]);

        text = text.replaceAll(emailInput, replacement.toString());

        System.out.println(text);
    }
}
