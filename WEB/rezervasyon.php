<?php
include("Header.php");
include("baglanti.php");

$id = $_GET['id'];

$sql = "SELECT * FROM motor WHERE id = $id";
$git = mysqli_query($baglanti, $sql);
$motor = mysqli_fetch_array($git);


?>

<html>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"
    integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css">
<link rel="stylesheet" href="admin.css">
<br>
<br>
<br>
<div class="containerUrun">
    <center>
        <div class="urun">
            <table cellpadding=0 cellspacing=0>
                <tr height=450px>
                    <td width=600px>
                        <div class="urunBilgi">
                            <img src=<?php echo "resim/" . $motor['resim_id'] . ".jpg" ?> class="urunresmi">
                            <p>
                                <?php echo $motor['model'] ?>
                            </p>
                            <span>
                                <?php echo $motor['aralik']." ".$motor['fiyat']."₺" ?>
                            </span>
                        </div>
                    </td>
                    <td>
                        <form method="post" action="bilgi.php?id=<?php echo $id ?>">
                            <input class="min" name="ad" type="text" value="Ad">
                            <input class="min" name="soyad" type="text" value="Soyad">
                            <input name="tel" type="text" value="Telefon No">
                            <input name="adres" type="text" value="Adres">
                            <input class="button" name="SatinAlButton" type="submit" value="Rezervasyon Yaptır">
                        </form>
                    </td>
                </tr height=450px>
            </table>
        </div>
    </center>
</div>
<br>

<br>

</html>