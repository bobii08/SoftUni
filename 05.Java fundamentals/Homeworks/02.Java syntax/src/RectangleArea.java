import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int aSide = scanner.nextInt();
        int bSide = scanner.nextInt();
        long rectArea = aSide * bSide;
        System.out.println(rectArea);
    }
}
