import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();

        while (text.contains("<upcase>")) {
            int indexOfUpcase = text.indexOf("<upcase>");
            int indexEndUpcase = text.indexOf("</upcase>");
            String uppercasedText = text.substring(indexOfUpcase + 8, indexEndUpcase).toUpperCase();
            String textToReplace = text.substring(indexOfUpcase, indexEndUpcase + 9);
            text = text.replace(textToReplace, uppercasedText);
        }
        System.out.println(text);
    }
}
