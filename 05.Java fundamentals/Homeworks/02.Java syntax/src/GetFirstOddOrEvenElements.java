import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] integersStr = scanner.nextLine().split(" ");
        String[] nextLine = scanner.nextLine().split(" ");
        int numberOfElements = Integer.parseInt(nextLine[1]);
        String kindOfNumbers = nextLine[2];
        List<Integer> collection = new ArrayList<>();
        for (String numberStr: integersStr) {
            collection.add(Integer.parseInt(numberStr));
        }

        ReturnElementsFromCollection(collection, numberOfElements, kindOfNumbers);
    }

    private static void ReturnElementsFromCollection(List<Integer> collection, int numberOfElements, String kindOfNumbers) {
        int count = 0;
        if (kindOfNumbers.equals("odd")) {
            for (int num : collection) {
                if (num % 2 != 0) {
                    System.out.print(num + " ");
                    count++;
                }

                if (count == numberOfElements) {
                    return;
                }
            }
        } else if (kindOfNumbers.equals("even")) {
            for (int num : collection) {
                if (num % 2 == 0) {
                    System.out.print(num + " ");
                    count++;
                }

                if (count == numberOfElements) {
                    return;
                }
            }
        }
    }
}
