import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] integers = Arrays.stream(scanner.nextLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int longestSeqLength = 1;
        int longestSeqStart = 0;

        int currentSeqLength = 1;
        int currentSeqStart = 0;

        for (int i = 1; i < integers.length; i++) {
            if (integers[i] == integers[i - 1]) {
                currentSeqLength++;

                if (currentSeqLength > longestSeqLength) {
                    longestSeqLength = currentSeqLength;
                    longestSeqStart = currentSeqStart;
                }
            }else {
                currentSeqLength = 1;
                currentSeqStart = i;
            }


        }

        for(int i=longestSeqStart; i<longestSeqStart+longestSeqLength; i++)
        {
            System.out.print(integers[i] + " ");
        }
    }
}

