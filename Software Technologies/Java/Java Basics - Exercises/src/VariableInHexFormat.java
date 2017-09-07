import java.util.Scanner;

public class VariableInHexFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String hecNum = scanner.nextLine();

        int decNum = Integer.parseInt(hecNum, 16);

        System.out.println(decNum);
    }
}
