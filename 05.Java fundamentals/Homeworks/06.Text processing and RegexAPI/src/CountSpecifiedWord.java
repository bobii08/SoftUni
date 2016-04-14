import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        String word = scanner.nextLine();
        text = text.toLowerCase();
        word = word.toLowerCase();
        String regExPattern = String.format("\\b%s\\b", word);
        Pattern pattern = Pattern.compile(regExPattern);
        Matcher matcher = pattern.matcher(text);
        int currentIndex = 0;
        int wordCount = 0;
        while (true) {
            if (matcher.find(currentIndex))  {
                wordCount++;
            } else {
                break;
            }

            currentIndex = matcher.start() + 1;
            if (currentIndex >= text.length()) {
                break;
            }
        }

        System.out.println(wordCount);
    }
}
