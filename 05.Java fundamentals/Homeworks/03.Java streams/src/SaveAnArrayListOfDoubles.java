import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class SaveAnArrayListOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream objectOutputStream = new ObjectOutputStream( new FileOutputStream(
                "D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\doubles.list"));
        List<Double> doubles = new ArrayList<>();
        doubles.add(5.6);
        doubles.add(45.6);
        doubles.add(3.46);
        objectOutputStream.writeObject(doubles);
        objectOutputStream.flush();
        ObjectInputStream objectInputStream = new ObjectInputStream(
                new FileInputStream("D:\\myrepo\\SoftUni\\05.Java fundamentals\\Homeworks\\03.Java streams\\doubles.list"));
        System.out.println(objectInputStream.readObject());
        objectInputStream.close();
    }
}