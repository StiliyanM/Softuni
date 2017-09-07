import java.util.Scanner;

public class integerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int decNum = Integer.parseInt(scanner.nextLine());

        String binaryNum = Integer.toBinaryString(decNum);
        String hecNum = Integer.toHexString(decNum).toUpperCase();

        System.out.println(hecNum);
        System.out.println(binaryNum);
    }
}
