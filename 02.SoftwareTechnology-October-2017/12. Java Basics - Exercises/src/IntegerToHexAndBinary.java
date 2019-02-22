import java.util.Scanner;

public class IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int input = Integer.parseInt(scanner.nextLine());
        String binaryResult = Integer.toBinaryString(input);
        String hexResult = Integer.toHexString(input);

       // System.out.println(decToHex(input));
        System.out.println(hexResult.toUpperCase());
        System.out.println(binaryResult);
    }


    public static String decToHex(int dec)
    {
        return Integer.toHexString(dec);
    }
}
