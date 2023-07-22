<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>MM</title>
  <link rel="stylesheet" href="style.css" />
</head>

<body>


  <div class="giris">
    <div class="form">

      <form name="giris-from" method="post">
        <p>Giriş Yap</p>
        <input type="text" name="kullaniciadi" placeholder="Admin Adınız" />
        <input type="password" name="parola" placeholder="Şifreniz" />
        <input type="submit" value="Giriş Yap">
      </form>

      <?php
      include("baglanti.php");


      if ($_POST) {

        $k_adi = $_POST["kullaniciadi"];
        $sifre = $_POST["parola"];

        $giris = "SELECT * FROM admin WHERE admin_adi='$k_adi' and sifre='$sifre'";
        $git = mysqli_query($baglanti, $giris);

        if ($git) {
          $kontrol = mysqli_fetch_array($git);

          if ($kontrol['admin_adi'] == $k_adi && $kontrol['sifre'] == $sifre) {
            header("Refresh:2; url=admin_panel.php");
            echo "<br>" . "Giriş Başarılı Lütfen Bekleyiniz";
          }
        }
      }

      ?>

    </div>
  </div>