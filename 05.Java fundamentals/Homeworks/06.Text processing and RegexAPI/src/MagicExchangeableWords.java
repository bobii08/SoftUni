import java.util.HashMap;
import java.util.Scanner;

public class MagicExchangeableWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] words = scanner.nextLine().split("\\s+");
        HashMap<Character, Character> hashMap = new HashMap<Character, Character>();
        String firstWord = words[0];
        String secondWord = words[1];
        for (int i = 0; i < firstWord.length(); i++) {
            char firstWordCurrentChar = firstWord.charAt(i);
            char secondWordCurrentChar = secondWord.charAt(i);
            if (!hashMap.containsKey(firstWordCurrentChar)) {
                hashMap.put(firstWordCurrentChar, secondWordCurrentChar);
            }
        }

        StringBuilder strB = new StringBuilder();
        for (int i = 0; i < words[1].length(); i++) {
            char currentChar = words[0].charAt(i);
            strB.append(hashMap.get(currentChar));
        }

        if (secondWord.equals(strB.toString())) {
            System.out.println(true);
        } else {
            System.out.println(false);
        }
    }
}
