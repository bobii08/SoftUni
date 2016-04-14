import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeMap;

public class LogsAggregator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        TreeMap<String, TreeMap<String, Integer>> logsData = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] arguments = scanner.nextLine().split("\\s+");
            String ip = arguments[0];
            String user = arguments[1];
            int duration = Integer.parseInt(arguments[2]);
            if (!logsData.containsKey(user)) {
                logsData.put(user, new TreeMap<>());
            }

            if (!logsData.get(user).containsKey(ip)) {
                logsData.get(user).put(ip, 0);
            }

            int prevDuration = logsData.get(user).get(ip);
            logsData.get(user).put(ip, prevDuration + duration);
        }

        for (String key : logsData.keySet()) {
            String name = key;
            System.out.print(name + ": ");
            int totalDuration = 0;
            for (String key2 : logsData.get(key).keySet()) {
                totalDuration += logsData.get(key).get(key2);
            }

            System.out.print(totalDuration + " ");
            ArrayList<String> currentIps = new ArrayList<>();
            for (String key3 : logsData.get(key).keySet()) {
                currentIps.add(key3);
            }

            System.out.println(currentIps);
        }
    }
}
