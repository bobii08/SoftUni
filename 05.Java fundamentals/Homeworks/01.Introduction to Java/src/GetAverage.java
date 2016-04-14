import java.util.Scanner;

public class GetAverage {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double firstNum = scanner.nextDouble();
        double secondNum = scanner.nextDouble();
        double thirdNum = scanner.nextDouble();
        double average = findAverage(firstNum, secondNum, thirdNum);
        System.out.println(String.format("%.2f", average));
    }

    private static double findAverage(double firstNum, double secondNum, double thirdNum) {
        return (firstNum + secondNum + thirdNum) / 3;
    }
}
