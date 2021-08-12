package factorial;

import java.util.Scanner;

public class Factorial {

    static long factorialCalculation(int num)
    {
        if (num == 0 || num == 1)
        {
            return num;
        }
        else
        {
            return num*factorialCalculation(num-1);
        }
    }
    
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.print("Enter a positive value: ");
        int number = s.nextInt(); //Taking user input
        
        long value = factorialCalculation(number);
        System.out.println("Factorial of " + number + " is " + value);
    }
    
}
