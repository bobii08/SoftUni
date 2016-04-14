import java.util.Scanner;

public class SumCards {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String[] arrOfCards = line.split("\\s+");
        int[] arrOfInts = new int[arrOfCards.length];
        for (int i = 0; i < arrOfCards.length; i++) {
            String currentFace = arrOfCards[i].substring(0, arrOfCards[i].length() - 1);
            switch (currentFace) {
                case "J":
                    arrOfInts[i] = 12;
                    break;
                case "Q":
                    arrOfInts[i] = 13;
                    break;
                case "K":
                    arrOfInts[i] = 14;
                    break;
                case "A":
                    arrOfInts[i] = 15;
                    break;
                default:
                    arrOfInts[i] = Integer.parseInt(currentFace);
            }
        }

        long totalSum = 0;
        for (int i = 0; i < arrOfInts.length; i++) {
            int currentCardValue = arrOfInts[i];
            if (i >= arrOfCards.length - 1) {
                totalSum += currentCardValue;
                break;
            }

            if (currentCardValue == arrOfInts[i + 1]) {
                i++;
                if (i >= arrOfInts.length - 1) {
                    totalSum += currentCardValue * 2 * 2;
                    break;
                }

                int currentCount = 2;
                while (true) {
                    if (currentCardValue == arrOfInts[i + 1]) {
                        currentCount++;
                        i++;
                        if (i >= arrOfInts.length - 1) {
                            totalSum += currentCardValue * currentCount * 2;
                            break;
                        }
                    } else {
                        totalSum += currentCardValue * currentCount * 2;
                        break;
                    }
                }
            } else {
                totalSum += currentCardValue;
            }
        }

        System.out.println(totalSum);
    }
}
