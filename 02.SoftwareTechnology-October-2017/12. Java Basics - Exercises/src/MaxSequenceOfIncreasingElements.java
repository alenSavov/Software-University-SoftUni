import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {


        public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);

            int[] integers = Arrays.stream(scanner.nextLine()
                    .split(" "))
                    .mapToInt(Integer::parseInt)
                    .toArray();

            int bestStart = 0;
            int bestLen = 0;
            int start = 0;
            int len = 1;

            for (int i = 1; i < integers.length; i++) {
                if (integers[i] > integers[i - 1]){
                    len++;
                }else{
                    start = i;
                    len = 1;
                }
                if (bestLen < len){
                    bestStart = start;
                    bestLen = len;
                }
            }

            for (int j = bestStart; j < bestStart + bestLen; j++) {
                System.out.print(integers[j] + " ");
            }

        }
    }


