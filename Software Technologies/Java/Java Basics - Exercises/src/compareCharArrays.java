import java.lang.reflect.Array;
import java.util.Scanner;

public class compareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] letters1 = scanner.nextLine().split(" ");
        String[] letters2 = scanner.nextLine().split(" ");

        int counter = Math.min(letters1.length, letters2.length);
        StringBuilder text1 = new StringBuilder();
        StringBuilder text2 = new StringBuilder();

        for (int i = 0; i < letters1.length ; i++) {
            text1.append(letters1[i]);
        }
        for (int i = 0; i < letters2.length; i++) {
            text2.append(letters2[i]);
        }

        for (int i = 0; i < counter; i++) {
            if (letters1[i].toCharArray()[0] < letters2[i].toCharArray()[0]) {
                System.out.println(text1);
                System.out.println(text2);
                return;
            }
            else if (letters1[i].toCharArray()[0] > letters2[i].toCharArray()[0]) {
                System.out.println(text2);
                System.out.println(text1);
                return;
            }
        }

        if (letters1.length == counter) {
            System.out.println(text1);
            System.out.println(text2);
        }
        else {
            System.out.println(text2);
            System.out.println(text1);
        }

    }
}
