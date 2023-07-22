<?php
include("baglanti.php");
session_start();
$id = $_GET['id'];

echo "Rezervasyon işleminiz başarılı lütfen bizlerden haber bekleyiniz.";

$ad = $_POST["ad"];
$soyad = $_POST["soyad"];
$tel = $_POST["tel"];
$adres = $_POST["adres"];
$hesap_id = $_SESSION['ID'];

if (($ad != null && $ad != "Ad") && ($soyad != null && $soyad != "Soyad") && ($tel != null && $tel != "Telefon No") && ($adres != null && $adres != "Adres")) {
    $rezerv = "INSERT INTO rezervasyon VALUES(NULL,'$ad','$soyad','$adres','$tel','$id','$hesap_id','0');";
    $gitRezerv = mysqli_query($baglanti, $rezerv);

    if ($gitRezerv) {
        header("Refresh:2; url=index.php");
    } else {
        header("Refresh:2; url=index.php");
    }
} else {
    echo "Rezervasyonunuz Tamalanamadı Lütfen Bilgilerinizi Eksiksiz Doldurunuz!!!";
}

?>