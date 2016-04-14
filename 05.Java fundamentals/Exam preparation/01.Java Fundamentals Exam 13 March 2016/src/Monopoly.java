import java.util.Scanner;

public class Monopoly {
    private static int TotalTurns = 0;

    private static int TotalMoney = 50;

    private static int TotalHotels = 0;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] rowAndCol = scanner.nextLine().split("\\s+");
        int row = Integer.parseInt(rowAndCol[0]);
        int col = Integer.parseInt(rowAndCol[1]);
        char[][] matrix = new char[row][col];
        for (int i = 0; i < row; i++) {
            String currentLine = scanner.nextLine();
            matrix[i] = new char[currentLine.length()];
            for (int j = 0; j < currentLine.length(); j++) {
                matrix[i][j] = currentLine.charAt(j);
            }
        }

        char currentChar = 's';
        for (int i = 0; i < row; i++) {
            if (i % 2 == 0) {
                for (int j = 0; j < col; j++) {
                    currentChar = matrix[i][j];
                    switch (currentChar) {
                        case 'H':
                            HotelAction();
                            break;
                        case 'J':
                            JailAction();
                            break;
                        case 'F':
                            FreeAction();
                            break;
                        case 'S':
                            ShopAction(i + 1, j + 1);
                            break;
                        default:
                            break;
                    }

                    CheckIfHaveBoughtHotels();
                }
            } else {
                for (int j = col - 1; j >= 0; j--) {
                    currentChar = matrix[i][j];
                    switch (currentChar) {
                        case 'H':
                            HotelAction();
                            break;
                        case 'J':
                            JailAction();
                            break;
                        case 'F':
                            FreeAction();
                            break;
                        case 'S':
                            ShopAction(i + 1, j +1);
                            break;
                        default:
                            break;
                    }

                    CheckIfHaveBoughtHotels();
                }
            }
        }

        System.out.printf("Turns %d", TotalTurns);
        System.out.println();
        System.out.printf("Money %d", TotalMoney);
    }

    private static void ShopAction(int row, int col) {
        TotalTurns++;
        int moneyToSpent = row * col;
        if (TotalMoney >= moneyToSpent) {
            System.out.printf("Spent %d money at the shop.", moneyToSpent);
            System.out.println();
            TotalMoney -= moneyToSpent;
        } else {
            System.out.printf("Spent %d money at the shop.", TotalMoney);
            System.out.println();
            TotalMoney = 0;
        }
    }

    private static void FreeAction() {
        TotalTurns++;
    }

    private static void JailAction() {
        System.out.printf("Gone to jail at turn %d.", TotalTurns);
        System.out.println();
        TotalTurns += 3;
        CheckIfHaveBoughtHotels();
        CheckIfHaveBoughtHotels();
    }

    private static void HotelAction() {
        TotalHotels++;
        TotalTurns++;
        System.out.printf("Bought a hotel for %d. Total hotels: %d.", TotalMoney, TotalHotels);
        System.out.println();
        TotalMoney = 0;
    }

    private static void CheckIfHaveBoughtHotels() {
        if (TotalHotels > 0) {
            TotalMoney += TotalHotels * 10;
        }
    }
}
