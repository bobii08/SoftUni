import java.util.*;

public class CardsFrequencies {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] arrOfCards = scanner.nextLine().split("\\s+");
        Map<String, Integer> cardFacesAndCount = new LinkedHashMap<>();
        for (String str : arrOfCards) {
            String cardFace = str.substring(0, str.length() - 1);
            if (!cardFacesAndCount.containsKey(cardFace)) {
                cardFacesAndCount.put(cardFace, 0);
            }

            cardFacesAndCount.put(cardFace, cardFacesAndCount.get(cardFace) + 1);
        }

        for (String key : cardFacesAndCount.keySet()) {
            double cardFrequency = (cardFacesAndCount.get(key) / (arrOfCards.length * 1.0)) * 100;
            System.out.printf("%s -> %.2f%%\n", key, cardFrequency);
        }
    }
}
