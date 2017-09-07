import java.util.Random;
import java.util.Scanner;

public class AdvertisementMessage {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] phrases = new String[] {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
        };

        String[] events  = new String[] {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
        };

        String[] authors = new String[] {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
        };

        String[] cities = new String[] {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
        };

        int num = Integer.parseInt(scanner.nextLine());

            Random random = new Random();

            for (int idx = 1; idx <= num; ++idx){

                int num1 = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = 0;

                if (num1 == 0) {
                    num1 = showRandomInteger(num1, phrases.length - 1, random);
                }
                if (num2 == 0) {
                    num2 = showRandomInteger(num2, events.length - 1, random);
                }
                if (num3 == 0) {
                    num3 = showRandomInteger(num3, authors.length - 1, random);
                }
                if (num4 == 0) {
                    num4 = showRandomInteger(num4, cities.length - 1, random);
                }

                System.out.println(String.format("%s %s %s - %s", phrases[num1], events[num2],
                        authors[num3], cities[num4]));

            }

    }

    private static Integer showRandomInteger(int aStart, int aEnd, Random aRandom){
        if (aStart > aEnd) {
            throw new IllegalArgumentException("Start cannot exceed End.");
        }
        long range = (long)aEnd - (long)aStart + 1;
        long fraction = (long)(range * aRandom.nextDouble());
        int randomNumber =  (int)(fraction + aStart);
        return randomNumber;
    }
}
