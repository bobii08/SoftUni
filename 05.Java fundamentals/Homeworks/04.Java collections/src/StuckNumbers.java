import java.util.Scanner;

public class StuckNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            arr[i] = scanner.nextInt();
        }

        if (n < 4) {
            System.out.println("No");
            return;
        }

        int firstNum = 0;
        int secondNum = 0;
        int thirdNum = 0;
        int fourthNum = 0;
        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            firstNum = arr[i];
            for (int j = 0; j < arr.length; j++) {
                secondNum = arr[j];
                if (firstNum == secondNum) {
                    continue;
                }

                for (int k = 0; k < arr.length; k++) {
                    thirdNum = arr[k];
                    if (secondNum == thirdNum) {
                        continue;
                    }

                    for (int l = 0; l < arr.length; l++) {
                        fourthNum = arr[l];
                        if (thirdNum == fourthNum) {
                            continue;
                        }

                        if (firstNum != secondNum && firstNum != thirdNum && firstNum != fourthNum &&
                                secondNum != thirdNum && secondNum != fourthNum && thirdNum != fourthNum) {
                            if ((firstNum + "" + secondNum).equals(thirdNum + "" + fourthNum)) {
                                System.out.println(firstNum + "|" + secondNum + "==" + thirdNum + "|" + fourthNum);
                                count++;
                            }
                        }
                    }
                }
            }
        }

        if (count == 0) {
            System.out.println("No");
        }
    }
}
