package lab2nr2nr3;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        // Creating a list of students
        List<String> listaStudentow = new ArrayList<>();
        listaStudentow.add("Enshtein");
        listaStudentow.add("Nowak");
        listaStudentow.add("Maestro");
        listaStudentow.add("Makson");
        listaStudentow.add("Lutik");

        // Randomly selecting an index within the range of 0 to the size of the list - 1
        int losowyIndex = (int) (Math.random() * listaStudentow.size());

        // Retrieving the student's last name with the selected index
        String wybraneNazwisko = listaStudentow.get(losowyIndex);

        // Displaying the selected last name on the screen
        System.out.println("Wybrane nazwisko ofiary: " + wybraneNazwisko);
    }
}

