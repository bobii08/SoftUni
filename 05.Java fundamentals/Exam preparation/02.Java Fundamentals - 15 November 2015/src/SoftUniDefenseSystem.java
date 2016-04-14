import java.math.BigDecimal;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SoftUniDefenseSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Pattern pattern = Pattern.compile("([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?([0-9]+)L");
        Matcher matcher = null;
        String person = "";
        String quantity = "";
        String drink = "";
        String line = scanner.nextLine();
        int totalLitres = 0;
        while (!line.equals("OK KoftiShans")) {
            matcher = pattern.matcher(line);
            if (matcher.find()) {
                person = matcher.group(1);
                drink = matcher.group(2);
                quantity = matcher.group(3);
                totalLitres += Integer.parseInt(quantity);
                System.out.printf("%s brought %s liters of %s!\n", person, quantity, drink.toLowerCase());
                while (matcher.find()) {
                    person = matcher.group(1);
                    drink = matcher.group(2);
                    quantity = matcher.group(3);
                    totalLitres += Integer.parseInt(quantity);
                    System.out.printf("%s brought %s liters of %s!\n", person, quantity, drink.toLowerCase());
                }
            }

            line = scanner.nextLine();
        }

        BigDecimal result = new BigDecimal(totalLitres);
        BigDecimal another = new BigDecimal("0.001");
        result = result.multiply(another);
        System.out.printf("%.3f softuni liters", result);
    }
}
