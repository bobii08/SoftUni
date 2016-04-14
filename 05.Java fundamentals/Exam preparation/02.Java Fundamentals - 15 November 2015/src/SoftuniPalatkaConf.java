import java.util.Scanner;

public class SoftuniPalatkaConf {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numberOfPeople = Integer.parseInt(scanner.nextLine());
        int n = Integer.parseInt(scanner.nextLine());
        int peopleWithPlaceToStay = 0;
        int fedPeople = 0;

        int quantity = 0;
        String type = "";
        for (int i = 0; i < n; i++) {
            String line = scanner.nextLine();
            String[] arguments = line.split("\\s+");
            type = arguments[2];
            quantity = Integer.parseInt(arguments[1]);
            if (arguments[0].equals("tents")) {
                if (type.equals("normal")) {
                    peopleWithPlaceToStay += 2 * quantity;
                } else {
                    peopleWithPlaceToStay += 3 * quantity;
                }
            } else if (arguments[0].equals("rooms")) {
                if (type.equals("single")) {
                    peopleWithPlaceToStay += quantity;
                } else if (type.equals("double")) {
                    peopleWithPlaceToStay += 2 * quantity;
                } else {
                    peopleWithPlaceToStay += 3 * quantity;
                }
            } else {
                if (type.equals("musaka")) {
                    fedPeople += 2 * quantity;
                }
            }
        }

        if (peopleWithPlaceToStay >= numberOfPeople) {
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d\n", peopleWithPlaceToStay - numberOfPeople);
        } else {
            System.out.printf("Some people are freezing cold. Beds needed: %d\n", numberOfPeople - peopleWithPlaceToStay);
        }

        if (fedPeople >= numberOfPeople) {
            System.out.printf("Nobody left hungry. Meals left: %d", fedPeople - numberOfPeople);
        } else {
            System.out.printf("People are starving. Meals needed: %d", numberOfPeople - fedPeople);
        }
    }
}
