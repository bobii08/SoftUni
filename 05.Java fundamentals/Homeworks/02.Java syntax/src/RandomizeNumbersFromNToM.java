import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class RandomizeNumbersFromNToM {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        int m = scanner.nextInt();

        if (n > m) {
            int oldValue = n;
            n = m;
            m = oldValue;
        }

        ArrayList<Integer> numbers = new ArrayList<>();
        for (int i = n; i <= m; i++) {
            numbers.add(i);
        }

        ArrayList<Integer> resultList = new ArrayList<>();

        int count = 0;
        Random random = new Random();
        while (count < numbers.size()) {
            int randomIndex = random.nextInt(numbers.size());
            if (!resultList.contains(numbers.get(randomIndex))) {
                count++;
                resultList.add(numbers.get(randomIndex));
            }
        }

        for (int num: resultList) {
            System.out.print(num + " ");
        }
    }
}
