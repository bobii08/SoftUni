import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class CopyJpgFile {
    public static void main(String[] args) throws IOException {
        FileInputStream fileInputStream = new FileInputStream("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\cat.jpg");
        FileOutputStream fileOutputStream = new FileOutputStream("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\copiedPictureOfCat.jpg");
        int byteContainer;
        while((byteContainer = fileInputStream.read())!=-1) {
            fileOutputStream.write(byteContainer);
        }

        fileInputStream.close();
        fileOutputStream.close();
    }
}