package com.company;

import java.util.Date;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        String name = "Pesho";
        int age = 28;
        double height = 1.84;

        System.out.println("My name is " + name);

        int x = 432432;
        int y = 25019;

        int result = x + y;
        System.out.println("Result: " + result);

        Date currentDate = new Date();
        System.out.println("Current date and time: " + currentDate);

        double firstVariable = 232.12;
        double secondVariable = 841.4213;
        double product = firstVariable * secondVariable;
        System.out.println(product);

        Scanner scanner = new Scanner(System.in);
        int userInput = Integer.parseInt(scanner.nextLine());

        userInput = userInput + 10;
        System.out.println("The user input + 10 = " + userInput);
        int firstNumFromConsole = Integer.parseInt(scanner.nextLine());
        int secondNumFromConsole = Integer.parseInt(scanner.nextLine());
        System.out.println(firstNumFromConsole * secondNumFromConsole);

        for (int i = 1; i <= 1000; i++) {
            System.out.print(i + " ");
        }
    }
}
