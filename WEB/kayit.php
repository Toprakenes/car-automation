
<?php
include("baglanti.php");
// baglanti.php sayfasını bağladık

//$name=$_POST["kaydet"][0];
//echo($name);

if(isset($_POST["kaydet"]))
{
    $name=$_POST["kullaniciadi"];
    $email=$_POST["email"];
    $parola=$_POST["parola"];
    

    $ekle="INSERT INTO kullanici (kullanici_adi, e_mail, sifre) VALUES ('$name','$email','$parola')";
    $calistirekle = mysqli_query($baglanti,$ekle);

    if ($calistirekle)
    {
      echo "Kaydınız Başarılı";
      header("Refresh:2; url=index.php");
    }
    else{
      echo "Kaydınız Başarısız";
      header("Refresh:2; url=kayit.php");
    }

    mysqli_close($baglanti);

}

else {echo($name);}