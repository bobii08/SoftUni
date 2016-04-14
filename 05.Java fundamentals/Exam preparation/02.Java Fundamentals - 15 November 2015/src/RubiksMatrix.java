import java.util.Scanner;

public class RubiksMatrix {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] arr = scanner.nextLine().split("\\s+");
        int rows = Integer.parseInt(arr[0]);
        int cols = Integer.parseInt(arr[1]);
        int[][] matrix = new int[rows][];
        int currentCount = 1;
        for (int row = 0; row < matrix.length; row++) {
            matrix[row] = new int[cols];
            for (int col = 0; col < cols; col++) {
                matrix[row][col] = currentCount;
                currentCount++;
            }
        }

        int n = Integer.parseInt(scanner.nextLine());

        String[] arguments = null;
        for (int i = 0; i < n; i++) {
            arguments = scanner.nextLine().split("\\s+");
            String direction = arguments[1];
            if (direction.equals("up") || direction.equals("down")) {
                int col = Integer.parseInt(arguments[0]);
                int moves = Integer.parseInt(arguments[2]);
                moves = moves % rows;
                if (direction.equals("up")) {
                    for (int numberOfIter = 0; numberOfIter < moves; numberOfIter++) {
                        int cell = matrix[0][col];
                        for (int row = 0; row < rows - 1; row++) {
                            matrix[row][col] = matrix[row + 1][col];
                        }

                        matrix[rows - 1][col] = cell;
                    }
                } else {
                    for (int numberOfIter = 0; numberOfIter < moves; numberOfIter++) {
                        int cell = matrix[rows - 1][col];
                        for (int row = rows - 1; row > 0; row--) {
                            matrix[row][col] = matrix[row - 1][col];
                        }

                        matrix[0][col] = cell;
                    }
                }
            } else {
                int row = Integer.parseInt(arguments[0]);
                int moves = Integer.parseInt(arguments[2]);
                moves = moves % cols;
                if (direction.equals("left")) {
                    for (int numberOfIter = 0; numberOfIter < moves; numberOfIter++) {
                        int cell = matrix[row][0];
                        for (int col = 0; col < cols - 1; col++) {
                            matrix[row][col] = matrix[row][col + 1];
                        }

                        matrix[row][cols - 1] = cell;
                    }
                } else {
                    for (int numberOfIter = 0; numberOfIter < moves; numberOfIter++) {
                        int cell = matrix[row][cols - 1];
                        for (int col = cols - 1; col > 0; col--) {
                            matrix[row][col] = matrix[row][col - 1];
                        }

                        matrix[row][0] = cell;
                    }
                }
            }
        }

        int currentNum = 1;
        int currRow = 0;
        int currCol = 0;
        while (true) {
            if (matrix[currRow][currCol] == currentNum) {
                System.out.println("No swap required");
                currentNum++;
                currCol++;
                if (currCol == cols) {
                    currCol = 0;
                    currRow++;
                }

                if (currRow == rows) {
                    break;
                }
            } else {
                int rowToBeSwapped = 0;
                int colToBeSwapped = 0;
                boolean hasFound = false;
                for (int row = 0; row < rows && !hasFound; row++) {
                    for (int col = 0; col < cols; col++) {
                        if (matrix[row][col] == currentNum && (row != currRow || col != currCol)) {
                            rowToBeSwapped = row;
                            colToBeSwapped = col;
                            hasFound = true;
                            break;
                        }
                    }
                }

                System.out.printf("Swap (%d, %d) with (%d, %d)\n", currRow, currCol, rowToBeSwapped, colToBeSwapped);
                int oldValue = matrix[currRow][currCol];
                matrix[currRow][currCol] = matrix[rowToBeSwapped][colToBeSwapped];
                matrix[rowToBeSwapped][colToBeSwapped] = oldValue;

                currentNum++;
                currCol++;
                if (currCol == cols) {
                    currCol = 0;
                    currRow++;
                }

                if (currRow == rows) {
                    break;
                }
            }
        }
    }
}
