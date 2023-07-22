<?php
session_start();
include("baglanti.php");


if ($_POST) {

    $k_adi = $_POST["kullaniciadi"];
    $sifre = $_POST["parola"];

    $giris = "SELECT * FROM kullanici WHERE kullanici_adi='$k_adi' and sifre='$sifre'";
    $git = mysqli_query($baglanti, $giris);

    if ($git) {
        $kontrol = mysqli_fetch_array($git);

        if ($kontrol['kullanici_adi'] == $k_adi && $kontrol['sifre'] == $sifre) {
            $_SESSION["ID"] = $kontrol['id'];
            $_SESSION["KA"] = $kontrol['kullanici_adi'];
            header("Refresh:2; url=index.php");
            echo "<br>" . "Giriş Başarılı Lütfen Bekleyiniz";
        }
    }
}

?>