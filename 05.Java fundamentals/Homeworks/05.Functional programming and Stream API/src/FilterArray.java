import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class FilterArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] arrayOfStrings = scanner.nextLine().split("\\s+");
        List<String> resultArray = Arrays.stream(arrayOfStrings)
                .filter(el -> el.length() > 3)
                .collect(Collectors.toList());

        for (String el : resultArray) {
            System.out.print(el + " ");
        }

        if (resultArray.size() == 0) {
            System.out.println("(empty)");
        }
    }
}
