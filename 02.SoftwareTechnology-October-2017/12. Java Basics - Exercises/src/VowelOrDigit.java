import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        if (isVowel(input)){
            System.out.println("vowel");
        }else if (isInteger(input)){
            System.out.println("digit");
        }else if (!isVowel(input)){
            System.out.println("other");
        }

    }

    private static boolean isVowel(String input) {

            return "AEIOUaeiou".indexOf(input) != -1;

    }
    public static boolean isInteger(String str) {
        try {
            Integer.parseInt(str);
            return true;
        } catch (NumberFormatException nfe) {
            return false;
        }
    }
}
