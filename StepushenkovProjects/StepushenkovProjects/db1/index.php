<!DOCTYPE html>
<html>
<body>

<?php
define("SERVERNAME", "fdb1028.awardspace.net");
define("USERNAME", "4301628_stepushenkov63334");
define("PASSWORD", "Wiliyam10.");
define("DBNAME", "4301628_stepushenkov63334");

// Sprawdź, czy formularz został przesłany
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Utwórz połączenie z bazą danych
    $conn = mysqli_connect(SERVERNAME, USERNAME, PASSWORD, DBNAME);
    // Sprawdź połączenie
    if (!$conn) {
        die("Connection failed: " . mysqli_connect_error());
    }

    // Pobierz dane z formularza
    $firstname = $_POST["firstname"];
    $lastname = $_POST["lastname"];
    $city = $_POST["city"];
    $street = $_POST["street"];
    $streetnumber = $_POST["streetnumber"];

    // Zapisz dane w bazie danych
    $sql = "INSERT INTO MyGuests (firstname, lastname, city, street, streetnumber) VALUES ('$firstname', '$lastname', '$city', '$street', '$streetnumber')";

    if (mysqli_query($conn, $sql)) {
        echo "New record created successfully";
    } else {
        echo "Error: " . $sql . "<br>" . mysqli_error($conn);
    }

    mysqli_close($conn);
}
?>

<h2>Formularz danych osobowych</h2>

<form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>">
  First Name: <input type="text" name="firstname"><br>
  Last Name: <input type="text" name="lastname"><br>
  City: <input type="text" name="city"><br>
  Street: <input type="text" name="street"><br>
  Street Number: <input type="text" name="streetnumber"><br>
  <input type="submit" value="Submit">
</form>

</body>
</html>