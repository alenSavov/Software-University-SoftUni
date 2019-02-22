import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class MostFrequentNumber {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] integers = Arrays.stream(scanner.nextLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int number = 0;
        int[] occurence = new int[65535];
        int minJ = 0;

        List<Integer> arrNum = new ArrayList<>();
        int occurencies = 0;

        for (int i = 0; i < integers.length; i++)
        {
            occurence[integers[i]]++;
        }

        int max = 0;
        for (int i = 0; i < occurence.length; i++) {
            if (occurence[i] > max){
                max = occurence[i];
            }
        }

        for (int i = 0; i < occurence.length; i++)
        {
            if (max == occurence[i])
            {
                number = i;
                occurencies++;

            }
        }

        if (occurencies > 1)
        {
            for (int j = 0; j < integers.length; j++)
            {

                if (integers[j] == number)
                {
                    if (j < minJ)
                    {
                        minJ = j;
                    }


                }
            }
            System.out.println(integers[minJ]);
        }else{
            System.out.println(number);
        }
    }
}

