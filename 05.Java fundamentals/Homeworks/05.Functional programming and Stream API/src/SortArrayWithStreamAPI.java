import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] arrayOfStrings = scanner.nextLine().split("\\s+");
        List<Integer> listOfInts = Arrays.stream(arrayOfStrings).map(Integer::parseInt).collect(Collectors.toList());
        Integer[] arrOfIntegers = new Integer[listOfInts.size()];
        for (int i = 0; i < listOfInts.size(); i++) {
            arrOfIntegers[i] = listOfInts.get(i);
        }

        String sortingOrder = scanner.nextLine();
        if (sortingOrder.equals("Ascending")) {
            List<Integer> sortedList = Arrays.stream(arrOfIntegers).sorted().collect(Collectors.toList());
            for (int num: sortedList) {
                System.out.print(num + " ");
            }
        } else if (sortingOrder.equals("Descending")) {
            List<Integer> sortedList = Arrays.stream(arrOfIntegers).sorted((a,b) -> b.compareTo(a)).collect(Collectors.toList());
            for (int num : sortedList) {
                System.out.print(num + " ");
            }
        }


    }
}
