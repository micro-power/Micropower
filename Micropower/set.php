<?php

// zmienna $dane, która będzie zapisana
// może także pochodzić z formularza np. $dane = $_POST['dane'];
$dane = $_GET['set'];
//$time = date("H:i:s");

$tekst = $dane."\r\n";

// przypisanie zmniennej $file nazwy pliku
$file = "komendy.txt";

// uchwyt pliku, otwarcie do dopisania
$fp = fopen($file, "a");

// blokada pliku do zapisu
flock($fp, 2);

// zapisanie danych do pliku
fwrite($fp, $tekst);

// odblokowanie pliku
flock($fp, 3);

// zamknięcie pliku
fclose($fp);
?>