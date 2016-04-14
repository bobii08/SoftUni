import java.util.*;
import java.util.stream.Collectors;

public class ChampionsLeague {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        HashMap<String, Integer> winStatistics = new HashMap<>();
        HashMap<String, TreeSet<String>> opponents = new HashMap<>();
        while (!line.equals("stop")) {
            String[] arguments = line.split(" \\| ");
            String firstTeam = arguments[0];
            String secondTeam = arguments[1];
            String[] firstScore = arguments[2].split(":");
            String[] secondScore = arguments[3].split(":");
            int firstTeamHomeGoals = Integer.parseInt(firstScore[0]);
            int secondTeamHomeGoals = Integer.parseInt(secondScore[0]);
            int firstTeamAwayGoals = Integer.parseInt(secondScore[1]);
            int secondTeamAwayGoals = Integer.parseInt(firstScore[1]);
            int firstTeamTotalGoals = firstTeamHomeGoals + firstTeamAwayGoals;
            int secondTeamTotalGoals = secondTeamHomeGoals + secondTeamAwayGoals;
            if (firstTeamTotalGoals > secondTeamTotalGoals) {
                updateWinStatistics(firstTeam, winStatistics, true);
                updateWinStatistics(secondTeam, winStatistics, false);
            } else if (secondTeamTotalGoals > firstTeamTotalGoals) {
                updateWinStatistics(firstTeam, winStatistics, false);
                updateWinStatistics(secondTeam, winStatistics, true);
            } else {
                if (firstTeamAwayGoals > secondTeamAwayGoals) {
                    updateWinStatistics(firstTeam, winStatistics, true);
                    updateWinStatistics(secondTeam, winStatistics, false);
                } else {
                    updateWinStatistics(firstTeam, winStatistics, false);
                    updateWinStatistics(secondTeam, winStatistics, true);
                }
            }

            addOpponents(firstTeam, secondTeam, opponents);
            line = scanner.nextLine();
        }

        winStatistics
                .entrySet()
                .stream()
                .sorted((x, y) -> {
                    if (x.getValue() != y.getValue()) {
                        return y.getValue().compareTo(x.getValue());
                    } else {
                        return x.getKey().compareTo(y.getKey());
                    }
                })
                .forEach(kvp -> {
                    System.out.println(kvp.getKey());
                    System.out.println("- Wins: " + kvp.getValue());
                    System.out.print("- Opponents: ");
                    TreeSet<String> currentOpponents = opponents.get(kvp.getKey());
                    Iterator it = currentOpponents.iterator();
                    while (it.hasNext()) {
                        Object el = it.next();
                        if (it.hasNext()) {
                            System.out.print(el + ", ");
                        } else {
                            System.out.print(el);
                        }
                    }

                    System.out.println();
                });
    }

    private static void updateWinStatistics(String team, HashMap<String, Integer> winStatistics, boolean isWinner) {
        if (!winStatistics.containsKey(team)) {
            winStatistics.put(team, 0);
        }

        if (isWinner) {
            winStatistics.put(team, winStatistics.get(team) + 1);
        }
    }

    private static void addOpponents(String firstTeam, String secondTeam, HashMap<String, TreeSet<String>> opponents) {
        if (!opponents.containsKey(firstTeam)) {
            opponents.put(firstTeam, new TreeSet<>());
        }

        if (!opponents.containsKey(secondTeam)) {
            opponents.put(secondTeam, new TreeSet<>());
        }

        opponents.get(firstTeam).add(secondTeam);
        opponents.get(secondTeam).add(firstTeam);
    }
}
