import java.io.*;

public class AllCapitals {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new FileReader("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\lines.txt"));
        String fullText = "";
        String temporaryString;

        while ((temporaryString = bufferedReader.readLine()) != null) {
            fullText += temporaryString.toUpperCase() + "\r\n";
        }

        PrintWriter printWriter = new PrintWriter(new BufferedWriter(new FileWriter("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\lines.txt")));
        printWriter.write(fullText);
        printWriter.flush();
        bufferedReader.close();
        printWriter.close();
    }
}