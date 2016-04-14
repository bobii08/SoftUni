import java.util.Scanner;

public class TinySporebat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int health = 5800;
        int glowcaps = 0;
        String line = scanner.nextLine();
        while(!line.equals("Sporeggar")) {
            for (int i = 0; i < line.length(); i++) {
                char currentChar = line.charAt(i);
                if (currentChar == 'L') {
                    health += 200;
                } else if (Character.isDigit(currentChar) && i == line.length() - 1) {
                    glowcaps += Integer.parseInt(Character.toString(currentChar));
                } else {
                    health -= currentChar;
                    if (health <= 0) {
                        System.out.printf("Died. Glowcaps: %d", glowcaps);
                        return;
                    }
                }
            }

            line = scanner.nextLine();
        }

        glowcaps -= 30;
        System.out.printf("Health left: %d\n", health);
        if (glowcaps >= 0) {
            System.out.printf("Bought the sporebat. Glowcaps left: %d", glowcaps);
        } else {
            System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.", glowcaps * (-1));
        }
    }
}
