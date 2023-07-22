<?php
include("HeaderAdmin.php");
include("baglanti.php");

function rezervasyonCard($id, $model, $fiyat, $aralik, $resim_id, $ad, $soyad, $adres, $tel)
{
    $card = "
    <div class='siparis'>
                    <img src='resim/$resim_id.jpg' height='150px'>
                    <div class='model'>
                        <span>Model</span>
                        <p>$model</p>
                    </div>
                    <div class='Ad Soyad'>
                        <span>Ad Soyad</span>
                        <p>$ad $soyad</p>
                    </div>
                    <div class='adres'>
                        <span>Adres</span>
                        <p>$adres</p>
                    </div>
                    <div class='tel'>
                        <span>Tel</span>
                        <p>$tel</p>
                    </div>
                    <div class='fiyat'>
                        <span>Fiyat</span>
                        <p>₺$fiyat</p>
                    </div>
                    <div class='fiyat'>
                    <span>Süre Aralığı</span>
                    <p>$aralik</p>
                </div>
                    <div class='iletisim'>
                        <a class='iletisimBtn' href='iletisim.php?id=$id'>İletişime Geç</a>
                </div>
                </div><br>";


    echo $card;

}

?>
<html>

<head>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.3.0/css/all.min.css">
    <link rel="stylesheet" href="admin.css">
</head>

<body>

    <div class="container">
        <div class="containerCards">
            <?php
            echo "<table cellspacing=30>";

            $sql = "SELECT rezervasyon.id AS 'id',ad,soyad,adres,tel, motor.model AS 'model', motor.fiyat AS 'fiyat', motor.aralik AS 'aralik', motor.resim_id AS 'resim' FROM rezervasyon,motor,kullanici WHERE motor.id = motor_id AND hesap_id = kullanici.id AND iletisim = 0;";
            $git = mysqli_query($baglanti, $sql);

            $rezerv_sayisi_getir = "SELECT COUNT(*) AS 'rezerv' FROM rezervasyon WHERE iletisim = 0;";
            $rezerv_sayisi_sorgu = mysqli_query($baglanti, $rezerv_sayisi_getir);
            $rezerv_sayisi_select = mysqli_fetch_array($rezerv_sayisi_sorgu);
            $rezerv_sayisi = $rezerv_sayisi_select["rezerv"];

            $satir = $rezerv_sayisi;
            $sutun = 1;

            for ($i = 0; $i <= $satir; $i++) {
                echo "<tr>";

                for ($j = 1; $j <= $sutun; $j++) {
                    echo "<td width=1000>";
                    if ($rezerv_sayisi > 0) {
                        $rezerv = mysqli_fetch_array($git);
                        if ($rezerv) {
                            rezervasyonCard($rezerv['id'], $rezerv['model'], $rezerv['fiyat'], $rezerv['aralik'], $rezerv['resim'], $rezerv['ad'], $rezerv['soyad'], $rezerv['adres'], $rezerv['tel']);
                            $rezerv_sayisi--;
                        }
                    }
                    echo "</td>";
                }

                echo "</tr>";
            }

            echo "</table>";
            ?>
        </div>
    </div>

</body>


</html>