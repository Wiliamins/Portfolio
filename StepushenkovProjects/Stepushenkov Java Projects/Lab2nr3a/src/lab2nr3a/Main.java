package lab2nr3a;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        // Create an ArrayList to store the randomly generated numbers
        ArrayList<Integer> wylosowaneLiczby = new ArrayList<>();
        // Initialize a random number generator
        Random rand = new Random();
        // Generate 6 unique random numbers between 1 and 49
        while (wylosowaneLiczby.size() < 6) {
            int losowaLiczba = rand.nextInt(49) + 1;
            // Check if the generated number is not already in the list
            if (!wylosowaneLiczby.contains(losowaLiczba)) {
                wylosowaneLiczby.add(losowaLiczba);
            }
        }
        // Sort the generated numbers in ascending order
        Collections.sort(wylosowaneLiczby);
        // Display the sorted numbers on the screen
        System.out.println("Wylosowane liczby w kolejnosci rosnacej: " + wylosowaneLiczby);
    }
}

