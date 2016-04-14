import java.util.Scanner;

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] arrOfStrings = scanner.nextLine().split("\\s+");
        int maxCount = 1;
        String mostFrequentlyPresentString = arrOfStrings[0];
        for (int i = 1; i < arrOfStrings.length; i++) {
            String currentString = arrOfStrings[i - 1];
            if (currentString.equals(arrOfStrings[i])) {
                int currentCount = 2;
                if (currentCount > maxCount) {
                    maxCount = currentCount;
                    mostFrequentlyPresentString = currentString;
                }

                i++;
                if (i >= arrOfStrings.length) {
                    break;
                }

                while (true) {
                    if (currentString.equals(arrOfStrings[i])) {
                        currentCount++;
                        if (currentCount > maxCount) {
                            maxCount = currentCount;
                            mostFrequentlyPresentString = currentString;
                        }

                        i++;
                        if (i >= arrOfStrings.length) {
                            break;
                        }
                    } else {
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < maxCount; i++) {
            System.out.print(mostFrequentlyPresentString + " ");
        }
    }
}
