import java.io.*;

public class SaveACustomObjectInAFile {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream objectOutputStream = new ObjectOutputStream(
                new FileOutputStream("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\course.save"));
        ObjectInputStream objectInputStream = new ObjectInputStream(
                new FileInputStream("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\course.save"));
        Course course = new Course("Java Fundamentals", 150);
        objectOutputStream.writeObject(course);
        Course readerObject = (Course)objectInputStream.readObject();
        readerObject.printInfo();
    }
}