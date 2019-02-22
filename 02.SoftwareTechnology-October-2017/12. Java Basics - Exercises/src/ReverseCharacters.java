import java.util.*;

public class ReverseCharacters {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List letterList = new ArrayList();

        for (int i = 1; i <= 3; i++) {
            String currentLetter = scanner.nextLine();
           letterList.add(currentLetter);
        }

        Collections.reverse(letterList);
        System.out.println(String.join("", letterList));
    }
}
