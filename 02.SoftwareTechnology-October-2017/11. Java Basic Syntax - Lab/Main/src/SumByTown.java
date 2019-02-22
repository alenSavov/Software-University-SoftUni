import java.util.Arrays;
import java.util.Scanner;
import java.util.TreeMap;

public class SumByTown {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String, Double> sumsByTown = new TreeMap<>();
        int countTown = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < countTown; i++) {

            String[] tokens = scanner.nextLine().split("\\|");
            String town = tokens[0].trim();
            double income = Double.parseDouble(tokens[1].trim());
            if (sumsByTown.containsKey(town)){
                sumsByTown.put(town, sumsByTown.get(town) + income);
            }else {
                sumsByTown.put(town, income);
            }
        }

        for (String key : sumsByTown.keySet()){
            System.out.println(key + " -> " + sumsByTown.get(key));
        }

    }
}
