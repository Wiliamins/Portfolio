<?php
$servername = "fdb1028.awardspace.net";
$username = "4301628_stepushenkov63334";
$password = "Wiliyam10.";
$dbname = "4301628_stepushenkov63334";
$connection = new mysqli($servername, $username, $password, $dbname);

if ($connection->connect_error) {
    die("Błąd połączenia: " . $connection->connect_error);
}

// Pobranie danych z formularza
$first_name = $_POST['first_name'];
$last_name = $_POST['last_name'];
$position = $_POST['position'];
$start_date = $_POST['start_date'];
$end_date = $_POST['end_date'];

// Zapis danych w bazie danych
$sql = "INSERT INTO vacationplan (first_name, last_name, position, start_date, end_date)
        VALUES ('$first_name', '$last_name', '$position', '$start_date', '$end_date')";

if ($connection->query($sql) === TRUE) {
    echo "Urlop został dodany";
} else {
    echo "Błąd podczas dodawania urlopu: " . $connection->error;
}

$connection->close();
?>