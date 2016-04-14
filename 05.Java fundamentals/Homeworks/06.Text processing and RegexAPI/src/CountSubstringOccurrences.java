import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String word = scanner.nextLine();
        line = line.toLowerCase();
        word = word.toLowerCase();
        Pattern pattern = Pattern.compile(word);
        Matcher matcher = pattern.matcher(line);
        int currentIndex = 0;
        int occurrencesCount = 0;

        while (true) {
            if (matcher.find(currentIndex)) {
                occurrencesCount++;
            } else {
                break;
            }


            currentIndex = matcher.start() + 1;
            if (currentIndex >= line.length()) {
                break;
            }
        }

        System.out.println(occurrencesCount);
    }
}
