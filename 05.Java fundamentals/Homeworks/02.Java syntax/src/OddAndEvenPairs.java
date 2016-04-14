import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();
        String[] numbersStr = line.split(" ");
        if (numbersStr.length % 2 != 0) {
            System.out.println("Invalid length");
            return;
        }

        List<Integer> numbers = new ArrayList<>();
        for (String strNum : numbersStr) {
            numbers.add(Integer.parseInt(strNum));
        }

        for (int i = 0; i < numbers.size() - 1; i += 2) {
            int firstNumberRemainder = numbers.get(i) % 2;
            int secondNumberRemainder = numbers.get(i + 1) % 2;
            if (firstNumberRemainder == secondNumberRemainder) {
                if (firstNumberRemainder == 0) {
                    System.out.println(numbers.get(i) + ", " + numbers.get(i + 1) + " -> both are even");
                } else {
                    System.out.println(numbers.get(i) + ", " + numbers.get(i + 1) + " -> both are odd");
                }
            } else {
                System.out.println(numbers.get(i) + ", " + numbers.get(i + 1) + " -> different");
            }
        }
    }
}
