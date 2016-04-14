import java.util.Scanner;

public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String firstString = scanner.next();
        String secondString = scanner.next();

        long result = MultiplyCharacters(firstString, secondString);
        System.out.println(result);
    }

    private static long MultiplyCharacters(String str1, String str2) {
        long totalSum = 0;
        if (str1.length() == str2.length()) {
            for (int i = 0; i < str1.length(); i++) {
                totalSum += str1.charAt(i) * str2.charAt(i);
            }
        } else if (str1.length() > str2.length()) {
            for (int i = 0; i < str2.length(); i++) {
                totalSum += str1.charAt(i) * str2.charAt(i);
            }

            for (int i = str2.length(); i < str1.length(); i++) {
                totalSum += str1.charAt(i);
            }
        } else {
            for (int i = 0; i < str1.length(); i++) {
                totalSum += str1.charAt(i) * str2.charAt(i);
            }

            for (int i = str1.length(); i < str2.length(); i++) {
                totalSum += str2.charAt(i);
            }
        }

        return totalSum;
    }
}
