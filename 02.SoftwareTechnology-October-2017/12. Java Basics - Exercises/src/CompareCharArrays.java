import java.util.Scanner;

public class CompareCharArrays {

    private static String first;

    private static String second;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        first = scanner.nextLine().replace(" ", "");
        second = scanner.nextLine().replace(" ", "");
        //swap strings so the shorter one is first
        if (first.length() > second.length()) {
            String temp = first;
            first = second;
            second = temp;
        }

        for (int i = 0; i < first.length(); i++) {
            if (first.charAt(i) > second.charAt(i)) {
                String temp = first;
                first = second;
                second = temp;
                break;
            }
        }
        System.out.println(first);
        System.out.println(second);
    }
}