import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class LogParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        HashMap<String, LinkedHashMap<String, ArrayList<String>>> projects = new HashMap<>();

        Pattern pattern = Pattern.compile("\\{\"Project\": \\[\"(.+?)\"\\], \"Type\": \\[\"(.+?)\"\\], \"Message\": \\[\"(.+?)\"\\]}");
        Matcher matcher;
        String line = scanner.nextLine();
        while (!line.equals("END")) {
            matcher = pattern.matcher(line);
            matcher.find();
            String projectName = matcher.group(1);
            String errorType = matcher.group(2);
            String message = matcher.group(3);

            if (!projects.containsKey(projectName)) {
                projects.put(projectName, new LinkedHashMap<>());
            }

            if (projects.get(projectName).size() == 0) {
                projects.get(projectName).put("Critical", new ArrayList<>());
                projects.get(projectName).put("Warnings", new ArrayList<>());
            }

            if (errorType.equals("Critical")) {
                projects.get(projectName).get("Critical").add(message);
            } else {
                projects.get(projectName).get("Warnings").add(message);
            }
            line = scanner.nextLine();
        }

        projects.entrySet().stream()
                .sorted((e1, e2) -> {
                    int total2 = e2.getValue().get("Critical").size() + e2.getValue().get("Warnings").size();
                    int total1 = e1.getValue().get("Critical").size() + e1.getValue().get("Warnings").size();

                    if (total1 != total2) {
                        return Integer.compare(total2, total1);
                    }

                    return e1.getKey().compareTo(e2.getKey());
                }).forEach(entry -> {
            String projectName = entry.getKey();
            System.out.println(projectName + ":");
            int totalErrors = entry.getValue().get("Critical").size() + entry.getValue().get("Warnings").size();
            System.out.println("Total Errors: " + totalErrors);
            int criticalErrorsCount = entry.getValue().get("Critical").size();
            System.out.println("Critical: " + criticalErrorsCount);
            int warningsErrorsCount = entry.getValue().get("Warnings").size();
            System.out.println("Warnings: " + warningsErrorsCount);
            List<String> criticalMessages = entry.getValue().get("Critical");
            criticalMessages = criticalMessages.stream().sorted((msg1, msg2) -> {
                if (msg1.length() != msg2.length()) {
                    return Integer.compare(msg1.length(), msg2.length());
                }

                return msg1.compareTo(msg2);
            }).collect(Collectors.toList());

            System.out.println("Critical Messages:");
            criticalMessages.forEach(m -> {
                System.out.print("--->");
                System.out.println(m);
            });

            if (criticalMessages.size() == 0) {
                System.out.println("--->None");
            }

            List<String> warningsMessages = entry.getValue().get("Warnings");
            warningsMessages = warningsMessages.stream().sorted((msg1, msg2) -> {
                if (msg1.length() != msg2.length()) {
                    return Integer.compare(msg1.length(), msg2.length());
                }

                return msg1.compareTo(msg2);
            }).collect(Collectors.toList());

            System.out.println("Warning Messages:");
            if (warningsMessages.size() > 0) {
                warningsMessages.forEach(m -> System.out.println("--->" + m));
            } else {
                System.out.println("--->None");
            }

            System.out.println();
        });
    }
}