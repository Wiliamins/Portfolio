<?php
$servername = "fdb1028.awardspace.net";
$username = "4301628_stepushenkov63334";
$password = "Wiliyam10.";
$dbname = "4301628_stepushenkov63334";

$connection = new mysqli($servername, $username, $password, $dbname);

// Sprawdzenie połączenia
if ($connection->connect_error) {
    die("Błąd połączenia: " . $connection->connect_error);
}

// Pobranie wszystkich danych z bazy SQL
$sql = "SELECT * FROM vacationplan";
$result = $connection->query($sql);

if ($result->num_rows > 0) {
    // Wyświetlenie danych w tabeli
    echo "<h2>Plan urlopów</h2>";
    echo "<table>";
    //Tworzę nagłówki dla tabeli
    echo "<tr><th>Imię</th><th>Nazwisko</th><th>Stanowisko pracy</th><th>Data początku urlopu</th><th>Data końca urlopu</th></tr>";

    while ($row = $result->fetch_assoc()) {
    //Dodaję komórki tabeli dla wygody i dobrego wyglądu
        echo "<tr>";
        echo "<td>".$row["first_name"]."</td>";
        echo "<td>".$row["last_name"]."</td>";
        echo "<td>".$row["position"]."</td>";
        echo "<td>".$row["start_date"]."</td>";
        echo "<td>".$row["end_date"]."</td>";
        echo "</tr>";
    }

    echo "</table>";
} else {
    echo "Brak danych o urlopach.";
}

$connection->close();
?>