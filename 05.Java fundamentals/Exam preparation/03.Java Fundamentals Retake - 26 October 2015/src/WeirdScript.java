import java.util.Scanner;

public class WeirdScript {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        char keyLetter = GetKeyLetter(n);
        String key = keyLetter + "" + keyLetter;
        String line = scanner.nextLine();
        StringBuilder stringBuilder = new StringBuilder();
        while (!line.equals("End")) {
            stringBuilder.append(line);
            line = scanner.nextLine();
        }

        int startIndex = 0;
        String strToSearchIn = stringBuilder.toString();
        while (true) {
            int firstIndex = strToSearchIn.indexOf(key, startIndex);
            int secondIndex = strToSearchIn.indexOf(key, firstIndex + 2);
            if (firstIndex != -1 && secondIndex != -1) {
                if (firstIndex + 2 != secondIndex) {
                    String strToBePrinted = strToSearchIn.substring(firstIndex + 2, secondIndex);
                    System.out.println(strToBePrinted);
                    startIndex = secondIndex + 2;
                } else {
                    startIndex = secondIndex + 2;
                }
            } else {
                break;
            }
        }
    }

    private static char GetKeyLetter(int n) {
        boolean isUpper = false;
        int num = (n - 1) / 26;
        if (num % 2 != 0) {
            isUpper = true;
        }

        n = (n - 1) % 26;
        if (isUpper) {
            return (char) (n + 65);
        }

        return (char) (n + 97);
    }
}
