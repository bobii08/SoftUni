import java.util.ArrayList;
import java.util.Scanner;

public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String firstLine = scanner.nextLine();
        String secondLine = scanner.nextLine();
        String[] firstLineArr = firstLine.split(" ");
        String[] secondLineArr = secondLine.split(" ");
        ArrayList<Character> firstList = new ArrayList<>();
        ArrayList<Character> secondList = new ArrayList<>();
        for (String s : firstLineArr) {
            firstList.add(s.charAt(0));
            System.out.print(s.charAt(0) + " ");
        }

        for (String s : secondLineArr) {
            secondList.add(s.charAt(0));
        }

        for (Character character : secondList) {
            if (!firstList.contains(character)) {
                System.out.print(character + " ");
            }
        }
    }
}
