import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class BasicMarkupLanguage {
    private static int CurrentCount = 1;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Pattern patternInverse = Pattern.compile("\\s*<\\s*inverse\\s+content\\s*=\\s*\"(.+)\"\\s*/\\s*>\\s*");
        Pattern patternReverse = Pattern.compile("\\s*<\\s*reverse\\s+content\\s*=\\s*\"(.+)\"\\s*/\\s*>\\s*");
        Pattern patternRepeat = Pattern.compile("\\s*<\\s*repeat\\s+value\\s*=\\s*\"(.+?)\"\\s+content\\s*=\\s*\"(.+?)\"\\s*/\\s*>\\s*");
        Pattern patternStop = Pattern.compile("\\s*<\\s*stop\\s*/\\s*>\\s*");
        String currentLine = scanner.nextLine();
        Matcher m = null;
        while (true) {
            m = patternInverse.matcher(currentLine);
            if (m.matches()) {
                String value = m.group(1);
                InverseAction(value);
                currentLine = scanner.nextLine();
                continue;
            }

            m = patternReverse.matcher(currentLine);
            if (m.matches()) {
                String value = m.group(1);
                ReverseAction(value);
                currentLine = scanner.nextLine();
                continue;
            }

            m = patternRepeat.matcher(currentLine);
            if (m.matches()) {
                int count = Integer.parseInt(m.group(1));
                String value = m.group(2);
                RepeatAction(count, value);
                currentLine = scanner.nextLine();
                continue;
            }

            m = patternStop.matcher(currentLine);
            if (m.matches()) {
                break;
            }

            currentLine = scanner.nextLine();
        }
    }

    private static void RepeatAction(int count, String value) {
        for (int i = 0; i < count; i++) {
            System.out.println(CurrentCount + ". " + value);
            CurrentCount++;
        }
    }

    private static void ReverseAction(String value) {
        System.out.print(CurrentCount + ". ");
        for (int i = value.length() - 1; i >= 0; i--) {
            System.out.print(value.charAt(i));
        }

        System.out.println();
        CurrentCount++;
    }

    private static void InverseAction(String value) {
        System.out.print(CurrentCount + ". ");
        for (int i = 0; i < value.length(); i++) {
            if (Character.isLowerCase(value.charAt(i))) {
                System.out.print(Character.toUpperCase(value.charAt(i)));
            } else {
                System.out.print(Character.toLowerCase(value.charAt(i)));
            }
        }

        System.out.println();
        CurrentCount++;
    }
}
