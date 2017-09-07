import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceoIncreasingElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();
        ArrayList<Integer> test = new ArrayList<Integer>();
        ArrayList<Integer> result = new ArrayList<Integer>();

        for (int i = 0; i < numbers.length - 1; i++) {
            if (numbers[i] < numbers[i + 1]) {
                test.add(numbers[i]);
                if (i != numbers.length - 2) {
                    if (numbers[i + 1] >= numbers[i + 2]) {
                        test.add(numbers[i + 1]);
                    }
                }
                else {
                    test.add(numbers[i + 1]);
                }
            }
            else {
                if (test.size() > result.size()) {
                    result = test;
                    test = new ArrayList<>();
                }
                else {
                    test = new ArrayList<>();
                }
            }
        }

        StringBuilder sb = new StringBuilder(1000);

        if (test.size() > result.size()) {
            for (int i = 0; i < test.size(); i++) {
                if (i != test.size() - 1) {
                    sb.append(test.get(i) + " ");
                }
                else {
                    sb.append(test.get(i));
                }
            }
        }
        else {
            for (int i = 0; i < result.size(); i++) {
                if (i != result.size() - 1) {
                    sb.append(result.get(i) + " ");
                }
                else {
                    sb.append(result.get(i));
                }
            }
        }

        System.out.println(sb);

    }
}
