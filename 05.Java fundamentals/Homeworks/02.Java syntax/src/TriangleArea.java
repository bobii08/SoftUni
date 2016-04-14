import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int firstPointX = scanner.nextInt();
        int firstPointY = scanner.nextInt();
        int secondPointX = scanner.nextInt();
        int secondPointY = scanner.nextInt();
        int thirdPointX = scanner.nextInt();
        int thirdPointY = scanner.nextInt();

        double area = Math.abs(
                ((firstPointX * (secondPointY - thirdPointY) +
                        secondPointX * (thirdPointY - firstPointY) +
                        thirdPointX * (firstPointY - secondPointY)) / 2));

        System.out.println((int) area);
    }
}
