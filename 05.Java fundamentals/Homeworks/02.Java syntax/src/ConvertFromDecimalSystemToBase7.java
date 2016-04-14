import java.util.Scanner;

public class ConvertFromDecimalSystemToBase7 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int integerNumber = scanner.nextInt();
        StringBuilder strB = new StringBuilder();
        do {
            strB.append(integerNumber % 7);
            integerNumber /= 7;
        }
        while (integerNumber != 0);

        System.out.println(strB.reverse());
    }
}
