import java.util.Scanner;

public class SequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] arrOfStrings = scanner.nextLine().split("\\s+");
        for (int i = 0; i < arrOfStrings.length; i++) {
            int count = 1;
            while (true) {
                if (i + 1 >= arrOfStrings.length) {
                    for (int j = 0; j < count; j++) {
                        System.out.print(arrOfStrings[i] + " ");
                    }

                    break;
                }

                if (arrOfStrings[i].equals(arrOfStrings[i + 1])) {
                    count++;
                } else {
                    for (int j = 0; j < count; j++) {
                        System.out.print(arrOfStrings[i] + " ");
                    }

                    System.out.println();
                    break;
                }

                i++;
            }
        }
    }
}
