import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        Map<String, Integer> sortedWordsWithTheirCount = new TreeMap<>();
        Pattern pattern = Pattern.compile("[a-zA-Z]+");
        Matcher matcher = pattern.matcher(line);
        while (matcher.find()) {
            String currentWord = matcher.group();
            if (!sortedWordsWithTheirCount.containsKey(currentWord)) {
                sortedWordsWithTheirCount.put(currentWord, 0);
            }

            sortedWordsWithTheirCount.put(currentWord.toLowerCase(), sortedWordsWithTheirCount.get(currentWord) + 1);
        }

        int maxCount = 0;
        for (String key: sortedWordsWithTheirCount.keySet()) {
            if (sortedWordsWithTheirCount.get(key) > maxCount) {
                maxCount = sortedWordsWithTheirCount.get(key);
            }
        }

        for (String key : sortedWordsWithTheirCount.keySet()) {
            if (sortedWordsWithTheirCount.get(key) == maxCount) {
                System.out.printf("%s -> %d times\n", key.toLowerCase(), sortedWordsWithTheirCount.get(key));
            }
        }
    }
}
