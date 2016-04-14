import java.math.BigDecimal;
import java.util.*;

public class SimpleExpression {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String[] arrOfNumbers = line.split("[^\\d\\.]+");
        String[] arrOfSigns = line.split("[^+-]+");
        List<String> numbers = new ArrayList<>();
        List<String> signs = new ArrayList<>();
        for (String numberStr : arrOfNumbers) {
            if (!numberStr.equals("")) {
                numbers.add(numberStr);
            }
        }

        for (String sign : arrOfSigns) {
            if (!sign.equals("")) {
                signs.add(sign);
            }
        }

        BigDecimal result = new BigDecimal(numbers.get(0));
        for (int i = 1; i < numbers.size(); i++) {
            String sign = signs.get(i - 1);
            BigDecimal number = new BigDecimal(numbers.get(i));
            switch (sign) {
                case "+":
                    result = result.add(number);
                    break;
                case "-":
                    result = result.subtract(number);
                    break;
            }
        }

        System.out.printf("%.7f", result);
    }
}
