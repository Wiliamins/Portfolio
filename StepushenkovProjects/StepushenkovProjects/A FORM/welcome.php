<html>
<body>
Witam <?php echo $_POST["imie"]; ?><br> 
Twoje nazwisko: <?php echo $_POST["nazwisko"]; ?><br>
Nazwa twojej ulicy: <?php echo $_POST["ulice"]; ?><br>
Numer twojego domu: <?php echo $_POST["numer_domu"]; ?><br>
Numer twojego mieszkania: <?php echo $_POST["numer_mieszkania"]; ?><br>
Miasto w którym mieszkasz: <?php echo $_POST["miasto"]; ?><br>
Twój kod pocztowy: <?php echo $_POST["kod_pocztowy"]; ?><br>
Twój wiek: <?php echo date('Y') - intval($_POST["rok_urodzenia"]); ?> lat.
</body>
</html>