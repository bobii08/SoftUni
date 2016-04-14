import java.io.*;

public class SumLines {
    public static void main(String[] args) {
        try (BufferedReader reader = new BufferedReader(new FileReader(new File("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\lines.txt")))) {
            String currentLine = reader.readLine();
            while (currentLine != null) {
                int currentLineSum = 0;
                for (int i = 0; i < currentLine.length(); i++) {
                    currentLineSum += currentLine.charAt(i);
                }

                System.out.println(currentLineSum);
                currentLine = reader.readLine();
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}