import java.util.Scanner;

public class CalculateNFactorial {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();
        System.out.println(calculateFactorial(number));
    }

    private static long calculateFactorial(int number) {
        if (number <= 1) {
            return 1;
        }

        return calculateFactorial(number - 1) * number;
    }
}
