import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] words = scanner.nextLine().split("\\s+");
        Pattern pattern = Pattern.compile("^[A-Z][a-zA-Z]*[A-Z]$");
        for (String word: words) {
            Matcher matcher = pattern.matcher(word);
            if (matcher.matches()) {
                System.out.print(word + " ");
            }
        }
    }
}
