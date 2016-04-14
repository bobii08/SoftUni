import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String word = scanner.next().toLowerCase();
        Pattern pattern = Pattern.compile("[a-zA-Z]+");
        Matcher matcher = pattern.matcher(line);
        String currentWord;
        int count = 0;
        while (matcher.find()) {
            currentWord = matcher.group();
            if (currentWord.toLowerCase().equals(word)) {
                count++;
            }
        }

        System.out.println(count);
    }
}
