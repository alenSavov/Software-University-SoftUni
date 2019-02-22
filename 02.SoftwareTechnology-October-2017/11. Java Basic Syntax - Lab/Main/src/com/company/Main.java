package com.company;

		import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);

		double num = Double.parseDouble(scanner.nextLine());
		double num2 = Double.parseDouble(scanner.nextLine());

		double sum = num + num2;
		System.out.println(sum);
	}
}
