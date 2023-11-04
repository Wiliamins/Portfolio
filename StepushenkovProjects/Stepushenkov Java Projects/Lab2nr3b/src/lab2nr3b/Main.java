package lab2nr3b;
import java.util.Random;
import java.util.TreeSet;

public class Main {
    public static void main(String[] args) {
        // Create a TreeSet to store the randomly generated numbers in ascending order
        TreeSet<Integer> wylosowaneLiczby = new TreeSet<>();
        // Initialize a random number generator
        Random rand = new Random();
        // Generate 6 unique random numbers between 1 and 49
        while (wylosowaneLiczby.size() < 6) {
            int losowaLiczba = rand.nextInt(49) + 1;
            // Add the generated number to the TreeSet
            wylosowaneLiczby.add(losowaLiczba);
        }
        // Display the sorted numbers on the screen
        System.out.println("Wylosowane liczby w kolejnosci rosnacej: " + wylosowaneLiczby);
    }
}
