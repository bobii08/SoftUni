import java.util.*;

public class ArrangeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String[] arrOfStrings = line.split(",\\s+");
        List<String> listOfStrings = new ArrayList<>();
        StringBuilder strB = new StringBuilder();
        for(String numStr: arrOfStrings) {
            if (numStr.length() == 1) {
                listOfStrings.add(GetStringAccordingToDigit(numStr.charAt(0)));
            } else {
                strB.delete(0, strB.length());
                for (int i = 0; i < numStr.length(); i++) {
                    if (i < numStr.length() - 1) {
                        strB.append(GetStringAccordingToDigit(numStr.charAt(i)) + "-");
                    } else {
                        strB.append(GetStringAccordingToDigit(numStr.charAt(i)));
                    }
                }

                listOfStrings.add(strB.toString());;
            }
        }

        Collections.sort(listOfStrings);
        for (int i = 0; i < listOfStrings.size(); i++) {
            if (i < listOfStrings.size() - 1) {
                System.out.print(GetNumberAccordingToString(listOfStrings.get(i)) + ", ");
            } else {
                System.out.print(GetNumberAccordingToString(listOfStrings.get(i)));
            }
        }
    }

    private static String GetStringAccordingToDigit(char charDigit) {
        switch (charDigit) {
            case '0': return "zero";
            case '1': return "one";
            case '2': return "two";
            case '3': return "three";
            case '4': return "four";
            case '5': return "five";
            case '6': return "six";
            case '7': return "seven";
            case '8': return "eight";
            case '9': return "nine";
            default:
                return "fuck you";
        }
    }

    private static String GetDigitAccordingToString(String digitAsString) {
        switch (digitAsString) {
            case "zero": return "0";
            case "one": return "1";
            case "two": return "2";
            case "three": return "3";
            case "four": return "4";
            case "five": return "5";
            case "six": return "6";
            case "seven": return "7";
            case "eight": return "8";
            case "nine": return "9";
            default:
                return "fuck you";
        }
    }

    private static String GetNumberAccordingToString(String numberArString) {
        String[] arrOfDigitsAsChars = numberArString.split("-");
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < arrOfDigitsAsChars.length; i++) {
            stringBuilder.append(GetDigitAccordingToString(arrOfDigitsAsChars[i]));
        }

        return stringBuilder.toString() ;
    }
}
