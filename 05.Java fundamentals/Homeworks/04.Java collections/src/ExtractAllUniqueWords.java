import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        Pattern pattern = Pattern.compile("\\w+");
        Matcher matcher = pattern.matcher(text);
        Set<String> sortedWords = new TreeSet<>();
        while (matcher.find()) {
            sortedWords.add(matcher.group().toLowerCase());
        }

        for (String word : sortedWords) {
            System.out.print(word + " ");
        }
    }
}
