import java.util.*;

public class PhonebookUpgrade {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String,String> phoneBook = new TreeMap<>();

        while(true){

            String[] tokens = scanner.nextLine().split(" ");

            String command = tokens[0];

            String name = "";
            if(Objects.equals(command, "END"))
                break;


            if(Objects.equals(command, "A")){

                name = tokens[1];
                String phoneNumber = tokens[2];
                if(!phoneBook.containsKey(name)){
                    phoneBook.put(name,"");
                }
                phoneBook.put(name,phoneNumber);
            }

            if(Objects.equals(command, "S")){

                name = tokens[1];

                if(phoneBook.containsKey(name)){
                    System.out.println(name + " -> " + phoneBook.get(name));
                }
                else
                    System.out.println(String.format("Contact %s does not exist.", name));
            }

            if(Objects.equals(command, "ListAll")){
                phoneBook.forEach((k,v) -> {
                    System.out.println(k + " -> " + v);
                });
            }
        }
    }
}
