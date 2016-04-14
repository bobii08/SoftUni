import java.util.Scanner;

public class PrintACharacterTriangle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String numberStr = scanner.next();
        int number = Integer.parseInt(numberStr);
        char charToPrint;
        for (int i = 0; i < number; i++) {
            charToPrint = 'a';
            for (int j = 0; j <= i; j++) {
                System.out.print(charToPrint + " ");
                charToPrint++;
            }

            System.out.println();
        }

        for (int i = 0; i < number - 1; i++) {
            charToPrint = 'a';
            for (int j = number - 1 - i; j > 0; j--) {
                System.out.print(charToPrint + " ");
                charToPrint++;
            }

            System.out.println();
        }
    }
}
