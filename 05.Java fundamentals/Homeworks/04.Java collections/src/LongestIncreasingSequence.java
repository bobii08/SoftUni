import java.util.*;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] arrOfStrings = scanner.nextLine().split("\\s+");
        List<Integer> numbers = new ArrayList<>();
        for (String str: arrOfStrings) {
            numbers.add(Integer.parseInt(str));
        }

        int maxCount = 1;
        int maxIndex = 0;
        for (int i = 0; i < numbers.size() - 1; i++) {
            int startIndex = i;
            if (numbers.get(i) < numbers.get(i + 1)) {
                int currentCount = 2;
                if (currentCount > maxCount) {
                    maxCount = currentCount;
                    maxIndex = startIndex;
                }

                i++;
                if (i == numbers.size() - 1) {
                    for (int j = startIndex; j < startIndex + currentCount; j++) {
                        System.out.print(numbers.get(j) + " ");
                    }

                    System.out.println();
                    break;
                }

                while (true) {
                    if (numbers.get(i) < numbers.get(i + 1)) {
                        currentCount++;
                        if (currentCount > maxCount) {
                            maxCount = currentCount;
                            maxIndex = startIndex;
                        }

                        i++;
                        if (i == numbers.size() - 1) {
                            for (int j = startIndex; j < startIndex + currentCount; j++) {
                                System.out.print(numbers.get(j) + " ");
                            }

                            System.out.println();
                            break;
                        }
                    } else {
                        for (int j = startIndex; j < startIndex + currentCount; j++) {
                            System.out.print(numbers.get(j) + " ");
                        }

                        System.out.println();
                        break;
                    }
                }
            } else {
                System.out.println(numbers.get(i));
            }
        }

        System.out.print("Longest: ");
        for (int i = maxIndex; i < maxCount + maxIndex; i++) {
            System.out.print(numbers.get(i) + " ");
        }
    }
}
