import java.util.Scanner;

public class SumNumbersFrom1ToN {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int number = Integer.parseInt(scanner.next());
        int sum = 0;
        for (int num = 1; num <= number; num++) {
            sum += num;
        }

        System.out.print(sum);
    }
}
