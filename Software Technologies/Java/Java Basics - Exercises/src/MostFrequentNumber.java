import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        int counter = 0;
        int number = 0;
        int bigCounter = 0;

        for (int i = 0; i < numbers.length; i++) {
            for (int j = 0; j < numbers.length; j++) {
                if (numbers[i] == numbers[j]) {
                    counter++;
                }
            }
            if (i == 0) {
                bigCounter = counter;
                number = numbers[i];
            }
            else {
                if (bigCounter < counter) {
                    bigCounter = counter;
                    number = numbers[i];
                }
            }
            counter = 0;
        }

        System.out.println(number);
    }
}
