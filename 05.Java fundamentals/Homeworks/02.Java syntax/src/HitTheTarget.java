import java.util.Scanner;

public class HitTheTarget {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();
        for (int i = 1; i <= 20; i++) {
            for (int j = 1; j <= 20; j++) {
                if (i + j == number) {
                    System.out.printf("%1$d + %2$d = %3$d", i, j, number);
                    System.out.println();
                } else if (i - j == number) {
                    System.out.printf("%1$d - %2$d = %3$d", i, j, number);
                    System.out.println();
                } else if (j - i == number) {
                    System.out.printf("%1$d - %2$d = %3$d", j, i, number);
                    System.out.println();
                }
            }
        }
    }
}
