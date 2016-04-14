import java.util.Scanner;

public class ConvertFromBase7ToDecimal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int base7Number = scanner.nextInt();
        int power = 0;
        int result = 0;
        while (base7Number != 0) {
            int remainder = base7Number % 10;
            result += Math.pow(7, power) * remainder;
            power++;
            base7Number /= 10;
        }

        System.out.println(result);
    }
}
