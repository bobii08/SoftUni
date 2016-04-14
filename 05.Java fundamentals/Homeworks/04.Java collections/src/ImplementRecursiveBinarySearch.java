import java.util.Scanner;

public class ImplementRecursiveBinarySearch {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();
        scanner.nextLine();
        String[] arrOfNums = scanner.nextLine().split(" ");
        int[] sortedArrayOfInts = new int[arrOfNums.length];
        for (int i = 0; i <arrOfNums.length; i++) {
            sortedArrayOfInts[i] = Integer.parseInt(arrOfNums[i]);
        }

        System.out.println(recursiveBinarySearch(sortedArrayOfInts, 0, sortedArrayOfInts.length - 1, number));
    }

    private static int recursiveBinarySearch(int[] sortedArr, int minIndex, int maxIndex, int searchedNumber) {
        if (minIndex > maxIndex) {
            return -1;
        }

        int midIndex = (minIndex + maxIndex) / 2;
        if (Integer.compare(sortedArr[midIndex], searchedNumber) == 0) {
            if (recursiveBinarySearch(sortedArr, minIndex, midIndex - 1, searchedNumber) != -1) {
                return recursiveBinarySearch(sortedArr,minIndex, midIndex -1, searchedNumber);
            } else {
                return midIndex;
            }
        } else if (sortedArr[midIndex] < searchedNumber) {
            return recursiveBinarySearch(sortedArr, midIndex + 1, maxIndex, searchedNumber);
        } else {
            return recursiveBinarySearch(sortedArr, minIndex, midIndex - 1, searchedNumber);
        }
    }
}
