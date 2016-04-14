import java.io.*;
import java.util.Arrays;

public class CountCharacterTypes {
    public static void main(String[] args) {
        int vowels = 0;
        int consonants = 0;
        int punctuationCount = 0;

        try (FileReader fileReader = new FileReader(new File("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\words.txt"));
             PrintWriter printWriter = new PrintWriter(new FileWriter("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\count-chars.txt"))) {
            int input = fileReader.read();
            while (input != -1) {
                char ch = (char) input;
                if (Character.isLetter(ch)) {
                    if (Arrays.asList(new Character[]{'a', 'e', 'i', 'o', 'u'}).contains(ch)) {
                        vowels++;
                    } else {
                        consonants++;
                    }
                } else if (Arrays.asList(new Character[]{'!', ',', '.', '?'}).contains(ch)) {
                    punctuationCount++;
                }

                input = fileReader.read();
            }

            printWriter.write(String.format("Vowels: %d\nConsonants: %d\nPunctuation: %d", vowels, consonants, punctuationCount));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}