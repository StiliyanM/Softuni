import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] arr = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();
        int[] nums = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        ArrayList<Integer> list = new ArrayList<Integer>();

        for (int i = 0; i < arr.length; i++) {
            list.add(arr[i]);
        }

        int specialNum = nums[0];
        int power = nums[1];

        for (int i = 0; i < list.size(); i++) {

            if (specialNum == list.get(i)) {

                int test = (list.size() - 1) - i;
                int deleteIndex = Math.min(power, test);

                for (int j = i + 1; j < list.size(); j++) {
                    if (deleteIndex != 0) {
                        list.remove(j);
                        deleteIndex--;
                    }
                    else {
                        break;
                    }
                }

                deleteIndex = Math.max(power, deleteIndex);

                for (int j = i - deleteIndex; j < i; j++) {
                    if (deleteIndex != 0) {
                        list.remove(j);
                        deleteIndex--;
                    }
                    else {
                        break;
                    }
                }

                for (int j = 0; j < list.size(); j++) {
                    if (specialNum == list.get(j)) {
                        list.remove(j);
                        i = 0;
                        break;
                    }
                }
            }
        }

        int sum = 0;

        for (int i = 0; i < list.size(); i++) {
            sum += list.get(i);
        }

        System.out.println(sum);
    }
}
