import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();

        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            arr[i] = scanner.nextInt();
        }

        boolean hasChanged = true;
        while (hasChanged) {
            hasChanged = false;
            for (int i = 0; i < arr.length - 1; i++) {
                if (arr[i] > arr[i + 1]) {
                    int oldValue = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = oldValue;
                    hasChanged = true;
                }
            }
        }

        for (int element : arr) {
            System.out.print(element + " ");
        }
    }
}
