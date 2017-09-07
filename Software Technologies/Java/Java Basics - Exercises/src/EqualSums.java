import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] arr = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < arr.length; i++) {

            int index = i;

            for (int j = 0; j < index; j++) {
                leftSum += arr[j];
            }

            for (int k = index + 1; k < arr.length; k++) {
                rightSum += arr[k];
            }

            if (rightSum == leftSum) {
                System.out.println(index);
                return;
            }
            else {
                leftSum = 0;
                rightSum = 0;
            }
        }

        if (leftSum == 0 && rightSum == 0) {
            System.out.println("no");
        }
    }
}
