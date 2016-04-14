import java.io.Serializable;

public class Course implements Serializable {
    private String name;
    private int numberOfStudents;

    public Course(String nameInput, int numberOfStudentsInput) {
        this.name = nameInput;
        this.numberOfStudents = numberOfStudentsInput;
    }

    public void printInfo()
    {
        System.out.println(name + " " + numberOfStudents);
    }
}