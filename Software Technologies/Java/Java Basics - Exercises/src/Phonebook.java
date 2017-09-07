import java.util.HashMap;
import java.util.Objects;
import java.util.Scanner;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        HashMap<String, String> phonebook = new HashMap<String, String>();

        while (true) {

            String[] input = scanner.nextLine().split(" ");

            String command = input[0];

            if (Objects.equals(command, "END")) {
                return;
            }

            if (Objects.equals(command, "A")) {
                String name = input[1];
                String phone = input[2];

                if (!phonebook.containsKey(name)) {
                    phonebook.put(name, "");
                }
                phonebook.put(name, phone);

            }
            if (Objects.equals(command, "S")) {
                String name = input[1];
                if (phonebook.containsKey(name)) {
                    System.out.println(name + " -> " + phonebook.get(name));
                } else {
                    System.out.println(String.format("Contact %s does not exist.", name));
                }
            }
        }
    }
}
