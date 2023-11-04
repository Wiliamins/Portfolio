<html>
<body>
Welcome <?php echo $_GET["name"]; ?><br> 
<!--
Metoda GET jest wykorzystywana do przesyłania niewielkich ilości danych,
które są publicznie dostępne, natomiast metoda POST jest preferowana do przesyłania większych ilości danych oraz 
danych poufnych, które powinny pozostać prywatne.
-->
Your email adress is: <?php echo $_GET["email"]; ?>
</body>
</html>
