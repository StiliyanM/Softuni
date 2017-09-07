import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class maxSequenceEqualElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] arr = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt)
                .toArray();

        int counter = 1;
        int number = 0;
        int bigCounter = 0;

        for (int i = 0; i < arr.length - 1; i++) {

                if (arr[i] == arr[i + 1]) {
                    counter++;
                }
                else {
                    int num = counter;
                    if (num > bigCounter) {
                        bigCounter = num;
                        number = arr[i];
                    }
                    counter = 1;
                }
        }

        StringBuilder result = new StringBuilder(1000);

        if (bigCounter != 0) {
            for (int i = 1; i <= bigCounter; i++) {
                if (i == bigCounter) {
                    result.append(number);
                } else {
                    result.append(number + " ");
                }
            }
            System.out.println(result);
        }
        else {
            number = arr[0];
            for (int i = 1; i <= counter; i++) {
                if (i == counter) {
                    result.append(number);
                } else {
                    result.append(number + " ");
                }
            }
            System.out.println(result);
        }
    }
}
